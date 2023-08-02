import math

def calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1):
    x = (d1 * 3) * math.tan(math.radians(theta1))
    l1 = math.sqrt(x**2 + (d1 * 3)**2)
    l2 = math.sqrt(((h * 3) - x)**2 + d2**2)
    t = ((1 / (v_sand * (5280 / 3600))) * (l1 + n * l2))
    return t

def find_optimal_angle(d1, d2, h, v_sand, n):
    min_time = float('inf')
    optimal_angle = 0
    for theta1 in range(0, 361): # Цикл от 0 до 360 градусов
        time = calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1)
        if time < min_time:
            min_time = time
            optimal_angle = theta1
    return optimal_angle, min_time

def get_user_input():
    d1 = float(input('Введите кратчайшее расстояние между спасателем и кромкой воды, d1 (ярды) => '))
    d2 = float(input('Введите кратчайшее расстояние от утопающего до берега, d2 (футы) => '))
    h = float(input('Введите боковое смещение между спасателем и утопающим, h (ярды) => '))
    v_sand = float(input('Введите скорость движения спасателя по песку, v_sand (мили в час) => '))
    n = float(input('Введите коэффициент замедления спасателя при движении в воде, n => '))
    return d1, d2, h, v_sand, n

def main():
    d1, d2, h, v_sand, n = get_user_input()
    optimal_angle, min_time = find_optimal_angle(d1, d2, h, v_sand, n)
    print(f'Оптимальный угол для начала движения спасателя: {optimal_angle} градусов. Он достигнет утопающего через {min_time} секунды.')

if __name__ == '__main__':
    main()

