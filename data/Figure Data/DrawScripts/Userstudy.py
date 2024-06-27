import matplotlib.pyplot as plt
import matplotlib.transforms as mtransforms
import numpy as np
import csv
from util import *

fontsize_x_ticks = 33
fontsize_y_ticks = 33
fontsize_x_label = 33
fontsize_y_label = 33

# Draw labels.
fig, axs = plt.subplot_mosaic([['(a) Image Quality', '  (b) User Experience']], constrained_layout=True,figsize=(20,8))

for label, ax in axs.items():
    print(label)
    # label physical distance to the left and up:
    trans = mtransforms.ScaledTranslation(140/72, 5/72, fig.dpi_scale_trans)
    ax.text(0, 1, label, transform=ax.transAxes + trans,
            fontsize=40, va='bottom', fontfamily='arial')

path = './Data/data-userstudy.csv'
f = open(path)
f_csv = csv.reader(f)

q1_yoro = np.asarray(next(f_csv), dtype=float)
q1_conv = np.asarray(next(f_csv), dtype=float)
q2_yoro = np.asarray(next(f_csv), dtype=float)
q2_conv = np.asarray(next(f_csv), dtype=float)

f.close()

ax = plt.subplot(1, 2, 1)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(q1_yoro))
plt.grid(zorder=0)

plt.yticks([1,2,3,4,5], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, range(1, len(q1_yoro) + 1), fontsize=fontsize_x_ticks)

plt.ylabel("Score", fontsize=fontsize_y_label)
plt.xlabel("Participant", fontsize=fontsize_x_label)

plt.bar(x_ticks-0.15, q1_yoro, 0.3, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks+0.15, q1_conv, 0.3, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)

fig.legend(ncol=2, loc = 'upper center', fontsize=33)

ax = plt.subplot(1, 2, 2)

[ax.spines[i].set_linewidth(2) for i in ax.spines]

x_ticks = np.arange(len(q1_yoro))
plt.grid(zorder=0)

plt.yticks([1,2,3,4,5], fontsize=fontsize_y_ticks)

plt.xticks(x_ticks, range(1, len(q1_yoro) + 1), fontsize=fontsize_x_ticks)

plt.ylabel("Score", fontsize=fontsize_y_label)
plt.xlabel("Participant", fontsize=fontsize_x_label)

plt.bar(x_ticks-0.15, q2_yoro, 0.3, color=get_color("YORO"), edgecolor='black', label='YORO', hatch=get_hatch('YORO'), zorder=10)
plt.bar(x_ticks+0.15, q2_conv, 0.3, color=get_color("Native"), edgecolor='black', label='Conventional', hatch=get_hatch('Native'), zorder=10)


plt.tight_layout(h_pad=-2,rect=(0,0,1,0.86))
plt.savefig("./output/userstudy.pdf", bbox_inches="tight")