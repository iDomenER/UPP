﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СведенияОДоходахФизлицДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции

		public void ВставитьКнопкуВПодменю(/*НомерКнопки, КнопкаПодменю, ИмяКнопки, ТипКнопки, ТекстКнопки = "", Действие = Неопределено*/)
		{
			//КнопкаПодменю.Кнопки.Вставить(НомерКнопки, ИмяКнопки, ТипКнопки, ТекстКнопки, Действие);
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		// Загружает форматы наборов записей файла сведений о доходах физлиц из заданного табличного документа

		public object ЗагрузитьФорматФайлаСведений(/*Знач МакетФормата, ЭтотОбъект*/)
		{
			//ФорматФайла = Новый Структура("НаборыЗаписей");
			//ФорматФайла.НаборыЗаписей = Новый Структура;
			//ОбластьФорматФайла = МакетФормата.ПолучитьОбласть("ФорматФайла");
			return null;
		}
		// ()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ ЧТЕНИЯ ФАЙЛА СВЕДЕНИЙ О ДОХОДАХ ФИЗЛИЦ ЗА 2003 ГОД
		// Выполняет чтение набора записей из файл сведений
		// Процедура выполняет последовательное чтение строк файла, инкрементируя счетчик прочитанных строк ТекущаяСтрокаФайла.
		// Каждая строка файла - запись данных.

		public object ПрочитатьНаборЗаписейИзФайла(/*НаборЗаписей, Файл, ТекущаяСтрокаФайла*/)
		{
			/*// Каждая запись может быть записана в файле сведений максимум 1 раз, но может быть и не записана.
*/
			/*// В любом случае записи в файле должны быть записаны последовательно.
*/
			/*// Построим из структуры-набора массив имен записей для индексного обращения 
*/
			//МассивИменЗаписейНабора = Новый Массив;
			//ПоследнийИндексЗаписиНабора = НаборЗаписей.Количество()-1;
			//ИндексТекущейЗаписиНабора = 0;
			while(true/*Истина*/)
			{
				/*// Прочитаем очередную запись файла
*/
				//ТекущаяСтрокаФайла = ТекущаяСтрокаФайла + 1;
				//СтрокаФайла = Файл.ПолучитьСтроку(ТекущаяСтрокаФайла);
				if(true/*СтрокаФайла = "@@@"*/)
				{
					/*// разделитель - признак окончания набора записей
*/
				}
				/*// Выделим из строки файла имя записи и сами данные
*/
				//ПозицияРазделителя = Найти(СтрокаФайла,":");
				//ИмяЗаписиФайла = Лев(СтрокаФайла, ПозицияРазделителя - 1);
				//СтрДанные = Сред(СтрокаФайла, ПозицияРазделителя + 1);
				/*// Попытаемся найти для имени записи файла соответствие в наборе записей
*/
				//Нашли = Ложь;
				while(true/*Не Нашли*/)
				{
					if(true/*(ИмяЗаписиФайла = МассивИменЗаписейНабора[ИндексТекущейЗаписиНабора])*/)
					{
						//Нашли = Истина;
					}
					if(true/*ИндексТекущейЗаписиНабора = ПоследнийИндексЗаписиНабора*/)
					{
					}
				}
				if(true/*(НЕ Нашли)*/)
				{
					//Сообщить("Неверный формат файла. В строке № " + ТекущаяСтрокаФайла +" указано неверное имя записи """ + ИмяЗаписиФайла + """!");
				}
				//ДанныеЗаписи = НаборЗаписей[ИмяЗаписиФайла];
				if(true/*ДанныеЗаписи.ТипДанных = "СТРУКТУРА"*/)
				{
					/*// В файле значения структуры перечисляются через запятую
*/
					//ВсегоПолей =  ДанныеЗаписи.Поля.Количество();
					//НомерПоля = 0;
				}
			}
			return null;
		}
		// Выполняет очистку данных набора записей

		public void ОчиститьДанныеНабораЗаписей(/*НаборЗаписей*/)
		{
			/*// Для каждой записи набора
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ОпределитьДействующиеСтавкиНалога(/*НалоговыйПериод, ЭтаФорма*/)
		{
			//ЭлементыФормы = ЭтаФорма.ЭлементыФормы;
			if(true/*НалоговыйПериод > 2007*/)
			{
				//ЭлементыФормы.РаботникиОрганизации.Колонки.Ставка.ЭлементУправления.ДоступныеЗначения.Очистить();
			}
		}
	}
}
