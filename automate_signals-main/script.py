import pyvisa
import time

#pyvisa.errors.VisualIOError as e

# Connect to VSG60 software using VISA socket connection
rm = pyvisa.ResourceManager()
print(rm.list_resources())
# vsg60 = rm.open_resource('TCPIP0::127.0.0.1::5024::SOCKET')

# # Set termination character and enable termination character detection
# vsg60.read_termination = '\n'
# vsg60.write_termination = '\n'
# vsg60.set_visa_attribute(pyvisa.constants.VI_ATTR_TERMCHAR_EN, True)


# print('IDN:' +str(vsg60.query('*IDN?')))

# # Set the output level and frequency
# vsg60.write('POW:AMPL -10') # Set output power level to -10 dBm
# vsg60.write('FREQ:CW 2.4 GHz') # Set frequency to 2.4 GHz

# # Turn on the RF output
# vsg60.write('OUTP:STAT ON')


# # Wait for 5 seconds
# time.sleep(30)

# # Turn off the RF output
# vsg60.write('OUTP:STAT OFF')

# # Close the connection to the VSG60 software
# vsg60.close()
