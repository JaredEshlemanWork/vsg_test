# vsg_test
Creating a GUI for automation of VSG60A devices.

The application *should* detect python (assuming it is installed) and the .py file automatically. 

If it doesn't, press the "Browse Python" button. With this, you can choose the python executable
(for me it is C://Windows//py.exe)

To use, press "Add File" to select a .csv file you would like to run. You (hopefully) are able to
add as many of these as you want, I only tested up to 4. 

Next, type in the Numeric Text Box that is in the top right, above the "Remove" button. This is
how long the corresponding .csv file will be transmitted for. this can be any number in seconds.

You can rearrange any of the .csv files or the pulse length times. Once you are satisfied,
press "Submit File" button.

Now you add the delays that you would like, and rearrange them to be in between whatever .csv files
you want to be delayed between. 

Currently, you need to add a delay in between all the .csv files, so if you want no delay between
them, just add a delay of 0 and put it in between (I will fix soon!)

Once you are satisfied, press "Begin", and the Signal Hound should start transmitting.

Please message me if any errors pop up, or if you have any questions!
