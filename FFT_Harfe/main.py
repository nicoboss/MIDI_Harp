'''
FFT_Harfe von Nico Bosshard (c)2016
'''

from __future__ import print_function
import os, sys, threading, math, time, threading, multiprocessing, pyaudio, struct
import numpy as np
from random import *

Code = []
Data = []
mic_chunks=[]

sampleRate=48100
bufferSize = 2048

comp=["==","!=","<",">"] #comparison operations
oper=[" and ", " or "] #boolean operations later maybe useing binary bitwise operations
moper=["+","*","**"] #arithmetic operations


def mic_stream():
    global chunks, stream, bufferSize
    while True:
        mic_chunks.append(stream.read(bufferSize))


def mic_listen(bufferSize, Code = [], mic = []):
    a=0
    for i in range(0,bufferSize*4):
        for e in Code[i]:
            exec(e)
    #print(mic)
    return a


if __name__ == '__main__':

    p = pyaudio.PyAudio()
    info = p.get_host_api_info_by_index(0)
    numdevices = info.get('deviceCount')
    #for each audio device, determine if is an input or an output and add it to the appropriate list and dictionary
    for i in range (0,numdevices):
        if p.get_device_info_by_host_api_device_index(0,i).get('maxInputChannels')>0:
            print("Input Device id ", i, " - ", p.get_device_info_by_host_api_device_index(0,i).get('name'))
        if p.get_device_info_by_host_api_device_index(0,i).get('maxOutputChannels')>0:
            print("Output Device id ", i, " - ", p.get_device_info_by_host_api_device_index(0,i).get('name'))
    devinfo = p.get_device_info_by_index(1)
    print("Selected device is ",devinfo.get('name')+"\n")

    stream = p.open(format=pyaudio.paFloat32,
                    channels=1, rate=48100, input=True, output=True)

    threading.Thread(target=mic_stream).start()
    time.sleep(1)
    while True:
        mic = mic_chunks.pop(0)
        stream.write(mic)
        #s="["
        #for q in mic:
        #    s+=str(q) + ","
        #s=s[:-1] + "]"
        #print(s)

        #if (1<2<3):print("Hi"

        print("Generating source code...")
        f = open("Code.txt","w")
        for i in range(0,bufferSize*4,1):
            #mic.append(randint(0,255))
            Subcode = []
            Subcode_count=0
            while Subcode_count<30:
                #z1=randint(0,255)
                #z2=randint(z1,255)
                #cmd="if "+str(0)+"<mic[i]<"+str(0)+":Data.append(1)\nelse:Data.append(0)"
                cmd="if mic[i]"+comp[randint(2,3)]+str(randint(0,255))+":a+=1"
                a=0
                exec(cmd)
                if(a==1):
                    f.write(cmd+"\n")
                    Subcode.append(cmd)
                    Subcode_count+=1
            Code.append(Subcode)
            #print(Subcode)
            #print(Data[Data.__len__()-1],end='') #too slow
        #print(Code)
        f.close()
        break

    print("done\n")
    #service = multiprocessing.Process(name='my_service', target=mic_listen, args=(mic_chunks.pop(0)))
    #service.start()
    multiprocessing.pool = multiprocessing.Pool(processes=1) # start 1 worker process
    while True:
        #RAM leack!
        mic_chunks.pop(0)
        result = multiprocessing.pool.apply_async(mic_listen, [bufferSize, Code, mic_chunks.pop(0),])
        #stream.write(mic_chunks[-1])
        #print(result.get())
        #print result.get(timeout=1)
        print(mic_chunks.__len__())
        while mic_chunks.__len__()<5:
            pass

##    a=0
##    b=0
##    for i in range(0,bufferSize/8):
##        for Subcode in Code:
##            for e in Subcode:
##                b+=1
##                exec(e)
##        print(str(a)+"/"+str(b))

    #print(Data)
