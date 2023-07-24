from vsgdevice.vsg_api import *
from time import sleep
import numpy as np

# def generate_iq():

#     # All device serial numbers that you want to use
#     serialNumbers = [20230979, 20230962, 20230883, 20230839]
#     handles = []

#     # Open device
#     for number in serialNumbers:
#         handles.append(vsg_open_device_by_serial(number)['handle'])

#     # Configure generator
#     freq = 1.0e9 # Hz
#     sample_rate = 50.0e6 # samples per second
#     level = -20.0 # dBm

#     for handle in handles:
#         vsg_set_frequency(handle, freq)
#         vsg_set_level(handle, level)
#         vsg_set_sample_rate(handle, sample_rate)

#         # Output CW, single I/Q value of {1,0}
#         # This is equivalent to calling vsgOutputCW
#         iq = numpy.zeros(2).astype(numpy.float32)
#         iq[0] = 1
#         vsg_repeat_waveform(handle, iq, 1)

#     # Will transmit until you close the device or abort
#     sleep(30)

#     for handle in handles:
#         # Stop waveform
#         vsg_abort(handle)

#         # Done with device
#         vsg_close_device(handle)

# if __name__ == "__main__":
#     generate_iq()


# # Set the filename and path of the IQ data file
# filename = 'iq_data.bin'
# filepath = '/path/to/folder/'

# # Define the data type of the IQ samples
# dtype = np.dtype([('I', np.int16), ('Q', np.int16)])

# # Read the binary file into a NumPy array
# iq_data = np.fromfile(filepath + filename, dtype)

# # Separate the I and Q components
# I = iq_data['I']
# Q = iq_data['Q']

def generate_iq():

    # All device serial numbers that you want to use
    #serialNumbers = [20230979, 20230962, 20230883, 20230839]
    serialNumbers = [20230839]
    # Use a dictionary to store the default values
    default_values = {
        'freq': 1.0e9,  # Hz
        'sample_rate': 50.0e6,  # samples per second
        'level': -20.0  # dBm
    }

    handles = []

    # Open device
    for number in serialNumbers:
        handle = vsg_open_device_by_serial(number)['handle']
        handles.append(handle)

        # Ask the user if they want to change the values for this device
        change_values_device = input(f"Do you want to change the values for device {number}? (yes or no): ")
        if change_values_device.lower() == "yes":
            # Prompt the user for the new values for this device
            freq = float(input(f"Enter the frequency for device {number} (in Hz): "))
            sample_rate = float(input(f"Enter the sample rate for device {number} (in samples per second): "))
            level = float(input(f"Enter the level for device {number} (in dBm): "))
        else:
            # Use the default values
            freq = default_values['freq']
            sample_rate = default_values['sample_rate']
            level = default_values['level']

        # Configure generator
        vsg_set_frequency(handle, freq)
        vsg_set_level(handle, level)
        vsg_set_sample_rate(handle, sample_rate)

        # Output CW, single I/Q value of {1,0}
        # This is equivalent to calling vsgOutputCW
        iq = numpy.zeros(2).astype(numpy.float32)
        iq[0] = 1
        vsg_repeat_waveform(handle, iq, 1)

        # Add a delay between opening each device to prevent overloading the system
        sleep(1)

    # Will transmit until you close the device or abort
    sleep(30)

    for handle in handles:
        # Stop waveform
        vsg_abort(handle)

        # Done with device
        vsg_close_device(handle)

if __name__ == "__main__":
    generate_iq()
