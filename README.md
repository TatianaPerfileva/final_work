## ЗАДАЧА ##

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []


## *Описание решения:* ##

* задаем первоначальный массив из строк, введенный с клавиатуры любой длины;

* задаем массив из строк, который получится по условию и в результате решения задачи, присваивая длину первоначального массива;

* выводим на экран первоначальный массив с использованием выделенного в отдельный метод PrintStringArray;

* с помощью метода FindArrayOfUpToThreeCharacters сортируем каждый элемент первоначального массива, удовлетворяющий условию задачи: длина элемента строки массива меньше или равна 3 символам. В результате формируется новый массив;

* с помощью метода PrintStringArray выводим полученный массив на экран.

**Блок-схема задачи находится в файле blok_diagram.JPG**

**Программа по решению задачи находится: project/Program.cs**
