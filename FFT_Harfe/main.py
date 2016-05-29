'''
FFT_Harfe von Nico Bosshard (c)2016
'''

from __future__ import print_function
import os, sys, threading, math, time, threading, multiprocessing, pyaudio, struct
import numpy as np
from random import *

Code = []
Data = []
ChunkNr_shared = multiprocessing.Value('i', 0)
Data_shared = multiprocessing.Array('b', 10000)
mic_chunks=[]

sampleRate=48100
bufferSize = 2048

AnzChunks=0

comp=["==","!=","<",">"] #comparison operations
oper=[" and ", " or "] #boolean operations later maybe useing binary bitwise operations
moper=["+","*","**"] #arithmetic operations


def mic_stream():
    global chunks, stream, bufferSize, AnzChunks
    while True:
        mic_chunks.append(stream.read(bufferSize))
        AnzChunks+=1


def mic_listen(ChunkNr, Data, bufferSize, Code = [], mic_data = []):
    print("Hi")
    mic = np.array(struct.unpack("%dB"%(bufferSize*4),mic_data))
    print(mic)
    a=0
    for i in range(0,bufferSize):
        for e in Code[i]:
            exec(e)
    #Data[ChunkNr.value]=a
    #ChunkNr.value=7
    print(a)
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
    time.sleep(0.2)
    while True:
        mic_data=mic_chunks.pop(0)
        mic = np.array(struct.unpack("%dB"%(bufferSize*4),mic_data))
        stream.write(mic_data)
        #s="["
        #for q in mic:
        #    s+=str(q) + ","
        #s=s[:-1] + "]"
        #print(s)

        #if (1<2<3):print("Hi"

        print("Generating source code...")
        f = open("Code.txt","w")
        for i in range(0,bufferSize*4,4):
            #mic.append(randint(0,255))
            Subcode = []
            Subcode_count=0
            while Subcode_count<4:
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

##    while True:
##        a=0
##        mic_data=stream.read(bufferSize)
##        mic = np.array(struct.unpack("%dB"%(bufferSize*4),mic_data))
##        print(mic[:500])
##        for i in range(0,bufferSize):
##            for e in Code[i]:
##                exec(e)
##        print(a)


    
    AnzChunks=0
    mic_chunks = []

    #Shared memory for pool of workers how to get this work?
    multiprocessing.pool = multiprocessing.Pool(processes=8) # start 1 worker process
    while True:
        while mic_chunks.__len__()<5:
            pass
        result = multiprocessing.pool.apply_async(mic_listen, [ChunkNr_shared, Data_shared, bufferSize, Code, mic_chunks.pop(0),])
        #stream.write(mic_chunks[-1])
        #print(Data_shared[:20])
        print(ChunkNr_shared.value)
        #print(result.get(timeout=1))
        #print("Az:" + str(AnzChunks) + "Ln:" + str(mic_chunks.__len__()),end='')

##    a=0
##    b=0
##    for i in range(0,bufferSize/8):,
##        for Subcode in Code:
##            for e in Subcode:
##                b+=1
##                exec(e)
##        print(str(a)+"/"+str(b))

    #print(Data)
