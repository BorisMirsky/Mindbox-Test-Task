Задание\
Напишите библиотеку для поставки внешним клиентам, 
которая умеет вычислять площадь круга по радиусу и треугольника 
по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты                                                         
- Легкость добавления других фигур                                     
- Вычисление площади фигуры без знания типа фигуры 
- Проверку на то, является ли треугольник прямоугольным      



1. Тесты \
Это браузерное приложение, и вся работа по валидации входящих данных сделана в классе модели.
Поэтому тесты не требуют обработки нуля, отрицательных чисел либо нечисловых типов данных.

2. Добавление других фигур \
Добавить новые поля в классе модели.\
Добавить новый метод в контроллере.\
Добавить новую форму в представлении.

3. Нахождение площади неизвестной фигуры.\
Не существует обобщения для такой задачи. \
Возможно, наиболее удачное решение - это задача определённого интеграла, т.е.
нахождение площади под графиком функции (или площади фигуры, ограниченной кривыми, заданными в прямоугольных координатах).
Мы предпологаем, что у неизвестной фигуры известны координаты точек, или ограничивающие
стороны можно представить как графики функций (правило Симпсона). 
Технически для этой цели можно использовать математическую библиотеку с возможностью нахождения интеграла, например
Math.NET Numerics (С#) или Scipy.Integrate (Python). Но в этом случае надо быть готовым к ощутимым погрешностям в точности.

4. Проверка на наличие прямого угла включена



Как пользоваться\
Предпологаем, что установлена VS.
Склонировали репозиторий. Дальше VS подхватила и поставила требуемые тут пакеты.
Запустили f5 либо зелёным треугольником.




Решение задачи по SQL находится в файле SqlTaskMindbox.sql.

