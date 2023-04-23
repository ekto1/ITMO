import math
import unittest

def get_user_input():
    d1 = input('Введите кратчайшее расстояние между спасателем и кромкой воды, d1 (ярды) => ')
    d2 = input('Введите кратчайшее расстояние от утопающего до берега, d2 (футы) => ')
    h = input('Введите боковое смещение между спасателем и утопающим, h (ярды) => ')
    v_sand = input('Введите скорость движения спасателя по песку, v_sand (мили в час) => ')
    n = input('Введите коэффициент замедления спасателя при движении в воде, n => ')
    theta1 = input('Введите направление движения спасателя по песку, theta1 (градусы) => ')

    return float(d1), float(d2), float(h), float(v_sand), float(n), float(theta1)

def calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1):
    x = (d1 * 3) * math.tan(math.radians(theta1))

    l1 = math.sqrt(x**2 + (d1 * 3)**2)
    l2 = math.sqrt(((h * 3) - x)**2 + d2**2)

    t = round(((1 / (v_sand * (5280 / 3600))) * (l1 + n * l2)), 1)

    return t

def main():
    d1, d2, h, v_sand, n, theta1 = get_user_input()
    t = calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1)
    print(f'Если спасатель начнёт движение под углом theta1, равным {int(theta1)} '
          f'градусам, он достигнет утопающего через {t} секунды')


class TestCalculateTimeToReachDrowningPerson(unittest.TestCase):

    def test_calculate_time_to_reach_drowning_person(self):
        # Здесь мы протестируем функцию с различными тестовыми случаями
        d1, d2, h, v_sand, n, theta1 = 5, 10, 3, 10, 2, 30
        result = calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1)
        expected = 2.5
        self.assertAlmostEqual(result, expected, delta=0.1)


def run_tests():
    unittest.main(argv=['first-arg-is-ignored'], exit=False)


def main():
    d1, d2, h, v_sand, n, theta1 = get_user_input()
    t = calculate_time_to_reach_drowning_person(d1, d2, h, v_sand, n, theta1)
    print(
        f'Если спасатель начнёт движение под углом theta1, равным {int(theta1)} градусам, он достигнет утопающего через {t} секунды')


if __name__ == '__main__':
    main()

    # Запускаем тесты после выполнения основной функции
    run_tests()


