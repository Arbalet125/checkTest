# Контрольная работа GeekBrains

**Задача:** *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. Первоначальный массив можно задать с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллециями, лучше обойтись исключительно массивами*

## Алгоритм работы:

1. Продумать структуру задачи и ее решение. 
    * Продумать наименования для переменных;
    * Продумать способ заполнения массива;
    * Продумать способ нахождения длины строки каждого элемента массива;
    * Продумать способ включения элементов изначального массива, заданной длинны в новый массив.
2. Проиллюстрировать решение задачи в виде блок-схемы.
3. Написать программу на языке С#. 

### Принятые решения: 

- Будем заполнять массив с клавиатуры через цикл For.
- Зададим длину строки, в виде переменной, короче которой должен быть элемент.
- Во время заполнения каждого элемента, будем сравнивать его с заданной чуть ранее переменной.
- Если условие **(длина.строки<=переменная)** выполняется, создаем новый цикл, для заполнения массива, в котором данный элемент массива будет соответствовать новому элементу нового массива.

### Решение задачи:

- [Блок схема draw.io]()
- [Решение задачи на языке С#]()
