/*
 * 1) Придумать и создать 3-4 класса, которые как минимум дважды наследуются и написать краткое описание текстом.
 * 2) Создать свой дженерик интерфейс IMyCloneable для реализации шаблона "Прототип".
 * 3) Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских конструкторов.
 * 4) Составить тесты или написать программу для демонстрации функции клонирования.
 * 5) Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.*/

using MyPatternPrototypeResearch;

Console.WriteLine("Привет!!!\nНиже будет продемонстрирован результат создания и клонирования некоторых организмов\n\n");

var commonNucleusCount = 1; // кол-во ядер в органе ЯДРО
var commonMitochondriaCount = 2; // кол-во митохондрий в клетке
var iterationCount = 2; // кол-во организмов в колонии
var organismIndex = 1;
var organismColony = new List<Organism>(); // список для хранения всех оригенальных организмов
var random = new Random();

for (int i = 0; i < iterationCount; i++)
{
    var nucleus = new Nucleus(commonNucleusCount);
    var cell = new Cell(nucleus, commonMitochondriaCount);

    organismColony.Add(new Organism(random.Next(0, 2) == 0, cell, organismIndex));
    organismColony[i].DescribeOrganism();
    organismIndex++;
}

Console.WriteLine("\n\nСклонированный перечень через интерфейс IMyCloneable");
var myCloneColony = organismColony.Select(x=>x.Clone(true) as Organism).ToList();
foreach(var myClone in myCloneColony)
{
    myClone?.DescribeOrganism();
}

Console.WriteLine("\n\nСклонированный перечень через интерфейс ICloneable");
var cloneColony = organismColony.Select(x => x.Clone() as Organism).ToList();
foreach (var clone in cloneColony)
{
    clone?.DescribeOrganism();
}