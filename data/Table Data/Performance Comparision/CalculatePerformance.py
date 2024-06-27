import numpy as np
import csv

path_output = "out.txt"
out = open(path_output, "w")

def load_data(path):
    data = {}
    with open(path) as f:
        f_csv = csv.reader(f)

        # ignore
        next(f_csv)

        for row in f_csv:
            scene_name = row[0].split("_")[0]
            mode = row[0].split("_")[1]
            frame_data = [float(value) for value in row[1:]]
            

            row = next(f_csv)
            memory_data = [float(value) for value in row[1:]]
            
            if scene_name not in data.keys():
                data[scene_name] ={mode: {'frame':np.asarray(frame_data), 'mem':np.asarray(memory_data)}}
            elif mode not in data[scene_name]:
                data[scene_name][mode] = {'frame':np.asarray(frame_data), 'mem':np.asarray(memory_data)}

    return data

def cal_avgframe(*datas, mode):
    result={mode:{}}
    for i in range(len(datas)):
        data = datas[i]
        for scene_name in data:
            scene_data = data[scene_name]
            if scene_name not in result[mode].keys():
                result[mode][scene_name] = {'count':0, 'sec':0}

            result[mode][scene_name]['count'] += np.sum(scene_data[mode]['frame'])
            result[mode][scene_name]['sec'] += len(scene_data[mode]['frame'])

    avg_frame = {mode:{}}
    avg_sec = {mode:{}}
    for scene_name in result[mode]:
        avg_frame[mode][scene_name] = result[mode][scene_name]['count']/ result[mode][scene_name]['sec']
        avg_sec[mode][scene_name] = result[mode][scene_name]['sec'] / len(datas) / len(result[mode])
    
    for scene_name in result[mode]:
        print("Scene {}: {}: {:.2f}".format(scene_name, mode,
            avg_frame[mode][scene_name]), file=out)

    print("{}: ".format(mode), end="", file=out)
    for scene_name in result[mode]:
        print("{:.1f} ".format(avg_frame[mode][scene_name]), end='', file=out)
    print("", file=out)

    avg_ssvr = np.sum(np.array(list(avg_frame[mode].values())[:])*np.array(list(avg_sec[mode].values())[:]))/np.sum(np.array(list(avg_sec[mode].values())[:]))
    print("Avg {}: {:.2f} {:.2f}ms".format(mode, avg_ssvr, 1000/avg_ssvr), file=out)
    print(file=out)

def cal_avgmem(*datas, mode):
    result={mode:{}}
    for i in range(len(datas)):
        data = datas[i]
        for scene_name in data:
            scene_data = data[scene_name]
            if scene_name not in result[mode].keys():
                result[mode][scene_name] = {'count':0, 'sec':0}

            result[mode][scene_name]['count'] += np.sum(scene_data[mode]['mem'])
            result[mode][scene_name]['sec'] += len(scene_data[mode]['mem'])

    avg_frame = {mode:{}}
    avg_sec = {mode:{}}
    for scene_name in result[mode]:
        avg_frame[mode][scene_name] = result[mode][scene_name]['count']/ result[mode][scene_name]['sec']
        avg_sec[mode][scene_name] = result[mode][scene_name]['sec'] / len(datas) / len(result[mode])
    
    for scene_name in result[mode]:
        print("Scene {}: {}: {:.2f}".format(scene_name, mode,
            avg_frame[mode][scene_name]), file=out)

    print("{}: ".format(mode), end="", file=out)
    for scene_name in result[mode]:
        print("{:.1f} ".format(avg_frame[mode][scene_name]), end='', file=out)
    print("", file=out)

    avg_ssvr = np.sum(np.array(list(avg_frame[mode].values())[:])*np.array(list(avg_sec[mode].values())[:]))/np.sum(np.array(list(avg_sec[mode].values())[:]))
    print("Avg {}: {:.2f}".format(mode, avg_ssvr), file=out)
    print(file=out)

path_honor30 = './Data/honor30.dat'
path_honor8 = './Data/honor8.dat'
path_honor30s = './Data/honor30s.dat'
path_samsungS21 = "./Data/samsungS21.dat"
path_mi6 = "./Data/mi6.dat"
path_samsungS10 = "./Data/samsungS10.dat"
path_quest = "./Data/quest2.dat"

data1 = load_data(path_honor30)
data2 = load_data(path_honor8)
data3 = load_data(path_honor30s)
data4 = load_data(path_samsungS21)
data5 = load_data(path_mi6)
data6 = load_data(path_samsungS10)
data7 = load_data(path_quest)


print("Honor30", file=out)
cal_avgframe(data1, mode="YORO")
cal_avgframe(data1, mode="Conventional")
cal_avgframe(data1, mode='Fink')

print("Honor8", file=out)
cal_avgframe(data2, mode="YORO")
cal_avgframe(data2, mode="Conventional")
cal_avgframe(data2, mode='Fink')

print("Honor30s", file=out)
cal_avgframe(data3, mode="YORO")
cal_avgframe(data3, mode="Conventional")
cal_avgframe(data3, mode='Fink')

print("SamsungS21", file=out)
cal_avgframe(data4, mode="YORO")
cal_avgframe(data4, mode="Conventional")
cal_avgframe(data4, mode='Fink')

print("Mi6", file=out)
cal_avgframe(data5, mode="YORO")
cal_avgframe(data5, mode="Conventional")
cal_avgframe(data5, mode='Fink')

print("SamsungS10", file=out)
cal_avgframe(data6, mode="YORO")
cal_avgframe(data6, mode="Conventional")
cal_avgframe(data6, mode='Fink')

print("Quest2", file=out)
cal_avgframe(data7, mode='YORO')
cal_avgframe(data7, mode='Conventional')
cal_avgframe(data7, mode='Fink')

print("Honor30", file=out)
cal_avgmem(data1, mode="YORO")
cal_avgmem(data1, mode="Conventional")
cal_avgmem(data1, mode='Fink')

print("Honor8", file=out)
cal_avgmem(data2, mode="YORO")
cal_avgmem(data2, mode="Conventional")
cal_avgmem(data2, mode='Fink')

print("Honor30s", file=out)
cal_avgmem(data3, mode="YORO")
cal_avgmem(data3, mode="Conventional")
cal_avgmem(data3, mode='Fink')

print("SamsungS21", file=out)
cal_avgmem(data4, mode="YORO")
cal_avgmem(data4, mode="Conventional")
cal_avgmem(data4, mode='Fink')

print("Mi6", file=out)
cal_avgmem(data5, mode="YORO")
cal_avgmem(data5, mode="Conventional")
cal_avgmem(data5, mode='Fink')

print("SamsungS10", file=out)
cal_avgmem(data6, mode="YORO")
cal_avgmem(data6, mode="Conventional")
cal_avgmem(data6, mode='Fink')

print("Quest2", file=out)
cal_avgmem(data7, mode='YORO')
cal_avgmem(data7, mode='Conventional')
cal_avgmem(data7, mode='Fink')

print("======================= Framerate and Memory with SPI ==================================", file=out)

path_honor30 = './Data/honor30_spi.dat'
path_honor8 = './Data/honor8_spi.dat'
path_honor30s = './Data/honor30s_spi.dat'
path_samsungS21 = "./Data/samsungS21_spi.dat"
path_mi6 = "./Data/mi6_spi.dat"
path_samsungS10 = "./Data/samsungS10_spi.dat"
path_quest = "./Data/quest2_spi.dat"

data1 = load_data(path_honor30)
data2 = load_data(path_honor8)
data3 = load_data(path_honor30s)
data4 = load_data(path_samsungS21)
data5 = load_data(path_mi6)
data6 = load_data(path_samsungS10)
data7 = load_data(path_quest)

print("Honor30", file=out)
cal_avgframe(data1, mode="YORO")
cal_avgframe(data1, mode="Conventional")
cal_avgframe(data1, mode='Fink')
cal_avgframe(data1, mode="SPI")

print("Honor8", file=out)
cal_avgframe(data2, mode="YORO")
cal_avgframe(data2, mode="Conventional")
cal_avgframe(data2, mode='Fink')
cal_avgframe(data2, mode="SPI")

print("Honor30s", file=out)
cal_avgframe(data3, mode="YORO")
cal_avgframe(data3, mode="Conventional")
cal_avgframe(data3, mode='Fink')
cal_avgframe(data3, mode="SPI")

print("SamsungS21", file=out)
cal_avgframe(data4, mode="YORO")
cal_avgframe(data4, mode="Conventional")
cal_avgframe(data4, mode='Fink')
cal_avgframe(data4, mode="SPI")

print("Mi6", file=out)
cal_avgframe(data5, mode="YORO")
cal_avgframe(data5, mode="Conventional")
cal_avgframe(data5, mode='Fink')
cal_avgframe(data5, mode="SPI")

print("SamsungS10", file=out)
cal_avgframe(data6, mode="YORO")
cal_avgframe(data6, mode="Conventional")
cal_avgframe(data6, mode='Fink')
cal_avgframe(data6, mode="SPI")

print("Quest2", file=out)
cal_avgframe(data7, mode='YORO')
cal_avgframe(data7, mode='Conventional')
cal_avgframe(data7, mode='Fink')
cal_avgframe(data7, mode="SPI")

print("Honor30", file=out)
cal_avgmem(data1, mode="YORO")
cal_avgmem(data1, mode="Conventional")
cal_avgmem(data1, mode='Fink')
cal_avgmem(data1, mode="SPI")

print("Honor8", file=out)
cal_avgmem(data2, mode="YORO")
cal_avgmem(data2, mode="Conventional")
cal_avgmem(data2, mode='Fink')
cal_avgmem(data2, mode="SPI")

print("Honor30s", file=out)
cal_avgmem(data3, mode="YORO")
cal_avgmem(data3, mode="Conventional")
cal_avgmem(data3, mode='Fink')
cal_avgmem(data3, mode="SPI")

print("SamsungS21", file=out)
cal_avgmem(data4, mode="YORO")
cal_avgmem(data4, mode="Conventional")
cal_avgmem(data4, mode='Fink')
cal_avgmem(data4, mode="SPI")

print("Mi6", file=out)
cal_avgmem(data5, mode="YORO")
cal_avgmem(data5, mode="Conventional")
cal_avgmem(data5, mode='Fink')
cal_avgmem(data5, mode="SPI")

print("SamsungS10", file=out)
cal_avgmem(data6, mode="YORO")
cal_avgmem(data6, mode="Conventional")
cal_avgmem(data6, mode='Fink')
cal_avgmem(data6, mode="SPI")

print("Quest2", file=out)
cal_avgmem(data7, mode='YORO')
cal_avgmem(data7, mode='Conventional')
cal_avgmem(data7, mode='Fink')
cal_avgmem(data7, mode="SPI")

out.close()

print("Output saved to {}".format(path_output))