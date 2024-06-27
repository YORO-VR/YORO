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
    print("Avg {}: {:.2f}".format(mode, avg_ssvr), file=out)
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
    print("Avg {}: {:.2f}MB".format(mode, avg_ssvr), file=out)
    print(file=out)

def cal_avgtime(*datas, mode):
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
    print("Avg {}: {:.2f}ms".format(mode, avg_ssvr), file=out)
    print(file=out)

path = './Data/PatcherFramerateAndMemory.dat'

data = load_data(path)

cal_avgframe(data, mode="Xiao")
cal_avgframe(data, mode="Median")
cal_avgframe(data, mode="NS")
cal_avgframe(data, mode="Telea")
cal_avgframe(data, mode="YORO")

cal_avgmem(data, mode="Xiao")
cal_avgmem(data, mode="Median")
cal_avgmem(data, mode="NS")
cal_avgmem(data, mode="Telea")
cal_avgmem(data, mode="YORO")

cal_avgtime(data, mode="GAN")
cal_avgmem(data, mode="GAN")

print("Output saved to out.txt")