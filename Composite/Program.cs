﻿using System;

namespace Composite
{
	// Структурные паттерны

	/*
	 * Composite — это паттерн, позволяющий нам соединить группу объектов в древовидную структуру, а впоследствии работать с ними, как с единичным объектом.
	 * Реализацию паттерна можно представить в виде любых объектов, которые соединены в древовидную структуру (то есть содержат подобъекты). 
	 * В данном случае отлично подойдут, к примеру, пункты меню. Пункты могут содержать подпункты с подменю, и так далее.
	 * 
	 * Когда использовать?
	 * Тогда, когда объекты должны быть реализованы в виде иерархической древовидной структуры.
	 * Когда клиентский код должен одинаково управлять как целыми объектами, так и их составными частями, 
	 *   то есть и целый объект, и его структурные части должны реализовывать один и тот же интерфейс.
	 */

	class Program
	{
		static void Main(string[] args)
		{
			/* Файловая система — хороший пример древовидной структуры объектов.
			 * Она представлена файлами и папками, при этом очевидно, что файл будет самой минимальной структурной единицей и не будет содержать подразделы. 
			 * При этом со всеми папками (в том числе вложенными) можно работать одинаково. Отличный вариант, чтобы реализовать паттерн Компоновщик.
			 */

			// Нам нужен общий интерфейс, описывающий все объекты нашей системы — файлы и папки. Создадим его: Component.cs

			// Теперь реализуем модель файла — наименьшей единицы нашей древовидной структуры. 
			// У файла нет подкомпонентов, поэтому методы Add() и Remove() тут реализованы не будут: File.cs

			// Модель папки-структуры, которая может содержать дочерние элементы (файлы или подпапки): Folder.cs

			// Теперь посмотрим на саму реализацию в клиентском коде: 

			// Создание корневой папки
			Component rootFolder = new Folder("Root");

			// Создание файла - компонента низшего уровня
			Component myFile = new File("MyFile.txt");

			// Создание папки с документами
			Folder documentsFolder = new Folder("MyDocuments");

			// Добавляем файл в корневую папки
			rootFolder.Add(myFile);

			// Добавляем подпапку для документов в корневую папку
			rootFolder.Add(documentsFolder);

			// показываем контент корневой папки
			rootFolder.Display();
		}
	}
}
