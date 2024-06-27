def get_color(title: str):
    if title == 'YORO':
        return '#C82432'
    elif title == 'Native':
        return '#9AC9DB'
    elif title == 'Fink':
        return '#F8AC8C'
    elif title == 'SPI':
        return '#2878B5'
    elif title == 'SSIM':
        return '#96C37D'
    elif title == 'PSNR':
        return '#F3D266'
    else:
        return '#ffffff'

def get_marker(title: str):
    if title == 'YORO':
        return 'o'
    elif title == 'Native':
        return 's'
    elif title == 'Fink':
        return 'v'
    elif title == 'SPI':
        return '^'
    else:
        return 'wrong'

def get_hatch(title: str):
    return None
    if title == 'YORO':
        return '-'
    elif title == 'Native':
        return '\\'
    elif title == 'Hybrid':
        return '/'
    elif title == 'SPI':
        return '.'
    else:
        return 'wrong'