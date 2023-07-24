from vsgdevice.vsg_api import *
import time
import numpy as np
import csv
import sys


def produce_signal(info):
    #info = f.split()

    numFiles = int(info[0])
    timeBetweenFiles = list(map(float, info[1:numFiles]))
    durationOfFiles = list(map(float, info[numFiles:int(2 * numFiles)]))
    files = info[int(2 * numFiles):]

    
    serialNumber = 20230839
    IQ_2Dlist = []
    for i in files:
        IQ_list = []
        with open(f'{i}', newline='') as csvFile:
            reader = csv.reader(csvFile)
            for row in reader:
                IQ_list.append(np.float32(float(row[0])))
                IQ_list.append(np.float32(float(row[1])))
        IQ_2Dlist.append(np.array(IQ_list))




#    with open('C:/Users/JaredEshleman/Downloads/123.txt', 'w') as file:
        #for i in timeList:
            #file.write(i + '\n')

    freq = 1.0e9 # Hz
    sample_rate = 50.0e6 # samples per second
    level = -20.0 # dBm

    handle = vsg_open_device_by_serial(serialNumber)['handle']

    vsg_set_frequency(handle, freq)
    vsg_set_level(handle, level)
    vsg_set_sample_rate(handle, sample_rate)
    i = 0
    test_times = []
    timeBetweenFiles.append(0)
    while i < len(IQ_2Dlist):
        
        vsg_repeat_waveform(handle, IQ_2Dlist[i], int(len(IQ_2Dlist[i]) / 2))
        time.sleep(durationOfFiles[i])
        start = time.time()
        if timeBetweenFiles[i] != 0:
            vsg_abort(handle)
            time.sleep(timeBetweenFiles[i])

        end = time.time()
        test_times.append(end - start)
        i += 1
    vsg_abort(handle)
    with open('C:/Users/JaredEshleman/Downloads/123.txt', 'w') as file:
        for i in test_times:
            file.write(str(i) + '\n')


if __name__ == "__main__":
    produce_signal(sys.argv[1:])

