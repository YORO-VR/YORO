import matplotlib.pyplot as plt
import matplotlib.transforms as mtransforms
from PIL import Image
import numpy as np
import csv
from util import *

fontsize_x_ticks = 33
fontsize_y_ticks = 33
fontsize_x_label = 33
fontsize_y_label = 33

# Draw labels
fig, axs = plt.subplot_mosaic([['a', 'b', 'c', 'd'], ['e', 'f', 'g', 'h'], ['i', 'j', 'k', 'l'], ['m', 'n', 'o', 'p']],
                              constrained_layout=True,figsize=(40,24), gridspec_kw={'width_ratios':[1,1,1,0.5]})


total_extra_label = 7
current_extra = 0
for label, ax in axs.items():
    # label physical distance to the left and up:
    trans = mtransforms.ScaledTranslation(-20/72, 13/72, fig.dpi_scale_trans)
    ax.text(0.0, 1.0, label, transform=ax.transAxes + trans,
            fontsize=45, va='bottom', fontfamily='arial')
    if current_extra >= total_extra_label or current_extra == 3:
        current_extra += 1
        continue
    trans = mtransforms.ScaledTranslation(445/72, 11/72, fig.dpi_scale_trans)
    # rect = Rectangle((1,1),1,1,color=get_color("SPI"))
    # ax.add_patch(rect)
    ax.text(0.0,1.0,"SPI failed", transform=ax.transAxes + trans,
        fontsize=35, va='bottom', fontfamily='arial', color= "white", fontweight='bold',
        bbox={'facecolor':get_color("SPI"), 'alpha':1, 'pad':10})
    current_extra += 1


# Draw fig.a Power Consumption
path = './Data/data-power.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()


ax = plt.subplot(4, 4, 1)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.yticks([0,100,200,300,400,500,600,700,800], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("Power Consunption (mW)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.2, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.2, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)

# Draw fig.b Frameraete
path = './Data/data-framerate.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax = plt.subplot(4, 4, 2)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.yticks([0,10,20,30,40,50,60], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("Frame Rate (FPS)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.2, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.2, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)

# Draw fig.c CPU overhead
path = './Data/data-overhead.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax = plt.subplot(4,4,3)
[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.yticks([0,20,40,60,80], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("CPU Overhead (%)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.2, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.2, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)


# Draw fig.d IPD
path = './Data/data-ipd.csv'

f = open(path)
f_csv = csv.reader(f)

x_ticks = np.asarray(next(f_csv), dtype=float)
y_ssim = np.asarray(next(f_csv), dtype=float)
y_psnr = np.asarray(next(f_csv), dtype=float)

f.close()

ax3 = plt.subplot(4,4,4)
plt.xticks(x_ticks, fontsize=fontsize_x_ticks)
plt.yticks([0.8,0.85,0.9,0.95,1], fontsize=fontsize_y_ticks)
plt.xlabel("IPD (cm)", fontsize=fontsize_x_label)
plt.ylabel("SSIM", fontsize=fontsize_y_label)
plt.ylim(0.8,1)

ax4 = ax3.twinx()
[ax3.spines[i].set_linewidth(2) for i in ax3.spines]

plt.ylim(20,40)
plt.yticks([20,25,30,35,40], fontsize=fontsize_y_ticks)

plt.ylabel("PSNR", fontsize=fontsize_y_label)

ax3.plot(x_ticks, y_ssim, color=get_color("SSIM"), label='SSIM', lw=4)
ax4.plot(x_ticks, y_psnr, color=get_color("PSNR"), label='PSNR', lw=4)

# Draw fig.e Temperature
path = './Data/data-temperature.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax = plt.subplot(4,4,5)
[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.ylim(20, 50)
plt.yticks([20,30,40,50], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("Temperature (℃)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.2, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.2, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)

# Draw fig.f Longitude-Framerate
path='./Data/data-longitude-framerate.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(4,4,6)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

plt.ylim(0,50)
len_yoro = len(y_yoro)
len_native = len(y_native)
len_fink = len(y_fink)

x_yoro = np.arange(0, len_yoro/60, 1/60)
x_native = np.arange(0, len_native/60, 1/60)
x_fink = np.arange(0, len_fink/60, 1/60)

y_ticks = [0,10,20,30,40,50]

plt.yticks(y_ticks, fontsize=fontsize_y_ticks)

plt.xticks([0,0.5,1,1.5,2,2.5,3], fontsize=fontsize_x_ticks)

plt.ylabel("Frame Rate (FPS)", fontsize=fontsize_y_label)
plt.xlabel("Time (h)", fontsize=fontsize_x_label)
plt.plot(x_native, y_native, color=get_color('Native'), label='Conventional', lw=4, marker=get_marker('Native'), ms=10,markevery=40)
plt.plot(x_yoro, y_yoro, color=get_color('YORO'), label='YORO',lw=4, marker=get_marker('YORO'), ms=10,markevery=40)
plt.plot(x_fink, y_fink, color=get_color('Fink'), label='Fink',lw=4, marker=get_marker('Fink'), ms=10,markevery=40)

# Draw fig.g Longitude-Memory Usage
path='./Data/data-longitude-memory.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(4,4,7)

ax = plt.gca()

[ax.spines[i].set_linewidth(2) for i in ax.spines]

plt.ylim(63,71)
len_yoro = len(y_yoro)
len_native = len(y_native)
len_fink = len(y_fink)

x_yoro = np.arange(0, len_yoro/60, 1/60)
x_native = np.arange(0, len_native/60, 1/60)
x_fink = np.arange(0, len_fink/60, 1/60)

y_ticks = [63,65,67,69,71]

plt.yticks(y_ticks, fontsize=fontsize_y_ticks)

plt.xticks([0,0.5,1,1.5,2,2.5,3], fontsize=fontsize_x_ticks)

plt.ylabel("Memory Usage (MB)", fontsize=fontsize_y_label)
plt.xlabel("Time (h)", fontsize=fontsize_x_label)
plt.plot(x_native, y_native, color=get_color('Native'), label='Conventional', lw=4, marker=get_marker('Native'), ms=10,markevery=40)
plt.plot(x_yoro, y_yoro, color=get_color('YORO'), label='YORO',lw=4, marker=get_marker('YORO'), ms=10,markevery=40)
plt.plot(x_fink, y_fink, color=get_color('Fink'), label='Fink',lw=4, marker=get_marker('Fink'), ms=10,markevery=40)

# Draw fig.h Image Quality-Shading
path = './Data/data-quality-shading.csv'

f = open(path)
f_csv = csv.reader(f)

y_ssim = np.asarray(next(f_csv), dtype=float)
y_psnr = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax1 = plt.subplot(4,4,8)
ax2 = ax1.twinx()

[ax1.spines[i].set_linewidth(2) for i in ax1.spines]

x_ticks = np.arange(len(names))


ax1.set_yticklabels([0,0.2,0.4,0.6,0.8,1], fontsize=fontsize_y_ticks)
ax2.set_yticklabels([0,10,20,30,40], fontsize=fontsize_y_ticks)
ax1.set_yticks([0,0.2,0.4,0.6,0.8,1])
ax2.set_yticks([0,10,20,30,40])

ax1.set_ylabel("SSIM", fontsize=fontsize_y_label)
ax2.set_ylabel("PSNR", fontsize=fontsize_y_label)

ax1.set_xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

ax1.bar(x_ticks-0.1, y_ssim, 0.2, color=get_color("SSIM"), edgecolor='black', label='SSIM', hatch=get_hatch('SSIM'), zorder=10)
ax2.bar(x_ticks+0.1, y_psnr, 0.2, color=get_color("PSNR"), edgecolor='black', label='PSNR', hatch=get_hatch('PNSR'), zorder=10)


# Draw fig.i Bandwidth
path = './Data/data-bandwidth.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv))

f.close()

ax = plt.subplot(4,4,9)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))

plt.grid(zorder=0)

y_ticks = np.asarray([0,1,2,3,4,5,6,7])
plt.yticks(y_ticks*1000,y_ticks, fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("Bit Rate (mbps)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.3, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks-0.1, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.1, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)
plt.bar(x_ticks+0.3, y_spi, 0.2, color=get_color("SPI"), edgecolor='black', label='SPI', hatch=get_hatch('SPI'), zorder=10)


# Draw fig.j Framerate with SPI
path = './Data/data-framerate-with-SPI.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax = plt.subplot(4,4,10)
[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.yticks([0,20,40,60,80], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("Frame Rate With SPI (FPS)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.3, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks-0.1, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.1, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)
plt.bar(x_ticks+0.3, y_spi, 0.2, color=get_color("SPI"), edgecolor='black', label='SPI', hatch=get_hatch('SPI'), zorder=10)


# Draw fig.k CPU Overhead with SPI
path = './Data/data-overhead-with-SPI.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax = plt.subplot(4,4,11)
[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(names))
plt.grid(zorder=0)

plt.yticks([0,20,40,60,80], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=22, ha='right')

plt.ylabel("CPU Overhead With SPI (%)", fontsize=fontsize_y_label)

plt.bar(x_ticks-0.3, y_yoro, 0.2, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks-0.1, y_native, 0.2, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)
plt.bar(x_ticks+0.1, y_fink, 0.2, color=get_color("Fink"), edgecolor='black', label='Fink et al.', hatch=get_hatch('Fink'), zorder=10)
plt.bar(x_ticks+0.3, y_spi, 0.2, color=get_color("SPI"), edgecolor='black', label='SPI', hatch=get_hatch('SPI'), zorder=10)


# Draw fig.l Image Quality-patcher
path = './Data/data-quality-patcher.csv'

f = open(path)
f_csv = csv.reader(f)

y_ssim = np.asarray(next(f_csv), dtype=float)
y_psnr = np.asarray(next(f_csv), dtype=float)

names = np.asarray(next(f_csv), dtype=str)

f.close()

ax1 = plt.subplot(4,4,12)
ax2 = ax1.twinx()

[ax1.spines[i].set_linewidth(2) for i in ax1.spines]

x_ticks = np.arange(len(names))

ax1.set_yticklabels([0,0.2,0.4,0.6,0.8,1], fontsize=fontsize_y_ticks)
ax2.set_yticklabels([0,10,20,30,40], fontsize=fontsize_y_ticks)
ax1.set_yticks([0,0.2,0.4,0.6,0.8,1])
ax2.set_yticks([0,10,20,30,40])

ax1.set_ylabel("SSIM", fontsize=fontsize_y_label)
ax2.set_ylabel("PSNR", fontsize=fontsize_y_label)

ax1.set_xticks(x_ticks, names, fontsize=fontsize_x_ticks, rotation=30, ha='right')

ax1.bar(x_ticks-0.1, y_ssim, 0.2, color=get_color("SSIM"), edgecolor='black', label='SSIM', hatch=get_hatch('SSIM'), zorder=10)
ax2.bar(x_ticks+0.1, y_psnr, 0.2, color=get_color("PSNR"), edgecolor='black', label='PSNR', hatch=get_hatch('PNSR'), zorder=10)


# Draw fig.m Complexity
path = './Data/data-complexity.csv'

f = open(path)
f_csv = csv.reader(f)

x_yoro = np.asarray(next(f_csv), dtype=float)
y_yoro = np.asarray(next(f_csv), dtype=float)

x_native = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)

x_fink = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)

x_spi = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(4, 4, 13)

ax = plt.gca()

[ax.spines[i].set_linewidth(2) for i in ax.spines]

y_ticks = [0,50,100,150,200,250]
x_ticks = np.array([0,2,4,6,8,10,12,14])

plt.yticks(y_ticks, fontsize=fontsize_y_ticks)
plt.xticks(x_ticks*1000,x_ticks, fontsize=fontsize_x_ticks)

plt.ylabel("Time (ms)", fontsize=fontsize_y_label)
plt.xlabel("Scene Complexity (${10^6}$ triangles)", fontsize=fontsize_x_label)

plt.plot(x_yoro, y_yoro, color=get_color("YORO"), label='YORO', lw=4, marker=get_marker("YORO"), ms=10, markevery=2)
plt.plot(x_native, y_native, color=get_color("Native"), label='Conventional', lw=4, marker=get_marker("Native"), ms=10, markevery=2)
plt.plot(x_fink, y_fink, color=get_color("Fink"), label='Fink et al.', lw=4, marker=get_marker("Fink"), ms=10, markevery=2)
plt.plot(x_spi, y_spi, color=get_color("SPI"), label='SPI', lw=4, marker=get_marker("SPI"), ms=10, markevery=2)


# Draw fig.n Framerate of Escape Room
path = './Data/data-quest-escaperoom.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(4,4,14)

[ax.spines[i].set_linewidth(2) for i in ax.spines]
plt.ylim(20,130)

len_yoro = len(y_yoro)
len_native = len(y_native)
len_fink = len(y_fink)
len_spi = len(y_spi)

x_yoro = np.arange(0, len_yoro/2, 0.5)
x_native = np.arange(0, len_native/2, 0.5)
x_fink = np.arange(0, len_fink/2, 0.5)
x_spi = np.arange(0, len_spi/2, 0.5)

y_ticks = np.arange(0, 130, 20)
x_ticks = np.arange(0, 50, 5)

plt.yticks(y_ticks, fontsize=fontsize_y_ticks)
plt.xticks(x_ticks, fontsize=fontsize_x_ticks)

plt.ylabel("Frame Rate", fontsize=fontsize_y_label)
plt.xlabel("Time (s)", fontsize=fontsize_x_label)

plt.plot(x_native, y_native, color=get_color("Native"), label='Conventional', lw=4, marker=get_marker("Native"), ms=10, markevery=8)
plt.plot(x_fink, y_fink, color=get_color("Fink"), label='Fink et al.', lw=4, marker=get_marker("Fink"), ms=10, markevery=8)
plt.plot(x_spi, y_spi, color=get_color("SPI"), label='SPI', lw=4, marker=get_marker("SPI"), ms=10, markevery=8)
plt.plot(x_yoro, y_yoro, color=get_color("YORO"), label='YORO', lw=4, marker=get_marker("YORO"), ms=10, markevery=8)


# Draw fig.o Framerate of VR Sample
path = './Data/data-quest-vrsample.csv'

f = open(path)
f_csv = csv.reader(f)

y_yoro = np.asarray(next(f_csv), dtype=float)
y_native = np.asarray(next(f_csv), dtype=float)
y_fink = np.asarray(next(f_csv), dtype=float)
y_spi = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(4,4,15)

[ax.spines[i].set_linewidth(2) for i in ax.spines]
plt.ylim(20,130)

len_yoro = len(y_yoro)
len_native = len(y_native)
len_fink = len(y_fink)
len_spi = len(y_spi)

x_yoro = np.arange(0, len_yoro/2, 0.5)
x_native = np.arange(0, len_native/2, 0.5)
x_fink = np.arange(0, len_fink/2, 0.5)
x_spi = np.arange(0, len_spi/2, 0.5)

y_ticks = np.arange(0, 130, 20)
x_ticks = np.arange(0, 50, 5)

plt.yticks(y_ticks, fontsize=fontsize_y_ticks)
plt.xticks(x_ticks, fontsize=fontsize_x_ticks)

plt.ylabel("Frame Rate", fontsize=fontsize_y_label)
plt.xlabel("Time (s)", fontsize=fontsize_x_label)

plt.plot(x_native, y_native, color=get_color("Native"), label='Conventional', lw=4, marker=get_marker("Native"), ms=10, markevery=8)
plt.plot(x_fink, y_fink, color=get_color("Fink"), label='Fink et al.', lw=4, marker=get_marker("Fink"), ms=10, markevery=8)
plt.plot(x_spi, y_spi, color=get_color("SPI"), label='SPI', lw=4, marker=get_marker("SPI"), ms=10, markevery=8)
plt.plot(x_yoro, y_yoro, color=get_color("YORO"), label='YORO', lw=4, marker=get_marker("YORO"), ms=10, markevery=8)


# Draw fig.p figure of Escape Room and VR Sample
plt.subplot(4,4,16)
embbed = Image.open('./EmbbedImgs/fig3.quest.png')

plt.xlim(0, embbed.width)
plt.ylim(embbed.height, 0)
plt.axis('off')
plt.imshow(embbed)


# Draw legends
lines = []
labels = []

axLine1, axLabel1 = fig.axes[9].get_legend_handles_labels()
axLine2, axLabel2 = fig.axes[12].get_legend_handles_labels()
axLine_modes = np.array(list(zip(axLine1, axLine2))).flatten()
axLabel_modes = np.array(list(zip(['']*4, [x + '   ' for x in axLabel1]))).flatten()

axLine1, axLabel1 = ax1.get_legend_handles_labels()
axLine2, axLabel2 = ax2.get_legend_handles_labels()
axLine1.extend(axLine2)
axLabel1.extend(axLabel2)

axLine2, axLabel2 = ax3.get_legend_handles_labels()
axLine3, axLabel3 = ax4.get_legend_handles_labels()
axLine2.extend(axLine3)
axLabel2.extend(axLabel3)

axline_metrics = np.array(list(zip(axLine1, axLine2))).flatten()
axLabel_metrics = np.array(list(zip(['']*2, [x + '   ' for x in axLabel1]))).flatten()

lines.extend(axLine_modes)
labels.extend(axLabel_modes)
lines.extend(axline_metrics)
labels.extend(axLabel_metrics)

fig.legend(lines, labels, ncol=12, loc = 'upper center', fontsize=33, borderpad=0.7, handletextpad=0.5, columnspacing=0.6)


plt.tight_layout(h_pad=-2,rect=(0,0,1,0.94))
plt.savefig("./output/fig3.pdf", bbox_inches="tight")