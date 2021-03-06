﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УчетРасходовНаПерсоналПереопределяемый
	{

		public void ДополнитьДвиженияСведениямиДляУпрУчета(/*Движения, Выборка, ДатаС, ДатаПо = Неопределено, ИмяПоляПодразделение = "Подразделение", ПрефиксИмениПоля = ""*/)
		{
			if(true/*ЗначениеЗаполнено(Выборка.СпособОтраженияВУпрУчете) ИЛИ Выборка.УчетНачисленийПоОрганизации*/)
			{
				//Движение = Движения.УчетЗаработкаРаботников.Добавить();
				/*// Свойства
*/
				//Движение.Период						= ДатаС;
				/*// Измерения
*/
				//Движение.Физлицо					= Выборка.Физлицо;
				/*// Ресурсы
*/
				//Движение.СпособОтраженияВУпрУчете	= Выборка[ПрефиксИмениПоля + "СпособОтраженияВУпрУчете"];
				//Движение.УчетНачисленийПоОрганизации= Выборка[ПрефиксИмениПоля + "УчетНачисленийПоОрганизации"];
				/*// добавляем "пустую" запись "по завершении"
*/
				if(true/*ЗначениеЗаполнено(ДатаПо)*/)
				{
					//Движение = Движения.УчетЗаработкаРаботников.Добавить();
					//Движение.Период			= НачалоДня(ДатаПо) + 3600 * 24;
					//Движение.Физлицо 		= Выборка.Физлицо;
				}
			}
		}

		public void НастройкаПараметровУчетаПередОткрытиемФормы(/*ОбработкаНастройкаПараметровУчета, Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы подразделения

		public void ПередОткрытиемФормыПодразделенияДополнительно(/*Форма, ДополнительныеДействия*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ВыполнитьДополнительныеДействияФормыПодразделения(/*Элемент, Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ОбработатьОповещениеФормыПодразделения(/*ИмяСобытия, Параметр, Источник, Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы форм объектов, участвующих в учете расходов на персонал

		public void ФормаВидаРасчетаУстановитьВидимостьДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ПередОткрытиемФормыКадровогоДокументаДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ПриОткрытииФормыДокументаПланированияУчетаЗатратДополнительно(/*Форма, ТабличнаяЧасть*/)
		{
			/*// Управление видимостью элементов формы, связанных с методом планирования затрат
*/
			//МетодПланированияУчетаЗатратНаПерсонал = Константы.МетодПланированияУчетаЗатратНаПерсонал.Получить();
			/*ПоказыватьКатегориюЗатраты = МетодПланированияУчетаЗатратНаПерсонал = Перечисления.МетодыПланированияУчетаЗатратНаПерсонал.КассовыйМетодСВыделениемНалогов
								ИЛИ МетодПланированияУчетаЗатратНаПерсонал = Перечисления.МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийСВыделениемНалогов;*/
			//ТабличнаяЧасть.Колонки.КатегорияЗатраты.Видимость			= ПоказыватьКатегориюЗатраты;
			//ТабличнаяЧасть.Колонки.КатегорияЗатраты.ИзменятьВидимость	= Ложь;
			/*// Управление доступностью категории затраты НДФЛ для выбора в документах
*/
			//МетодПланированияУчетаЗатратНаПерсонал = Константы.МетодПланированияУчетаЗатратНаПерсонал.Получить();
			/*// Скрывать категорию имеет смысл только если у пользователя установлен метод начислений с выделением налогов
*/
			//СкрытьКатегориюЗатратыНДФЛ = МетодПланированияУчетаЗатратНаПерсонал = Перечисления.МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийСВыделениемНалогов;
			if(true/*Не СкрытьКатегориюЗатратыНДФЛ*/)
			{
			}
			//ДоступныеЗначения = ТабличнаяЧасть.Колонки.КатегорияЗатраты.ЭлементУправления.ДоступныеЗначения;
			/*// Переберем все значения через метаданные
*/
			/*// Это позволит не дорабатывать функцию при появлении новых категорий
*/
		}

		public void ФормаСценарияПланированияДополнительно(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Прочие процедуры и функции

		public void ИменаДополнительныхТиповДополнитьОбъектамиУчетаРасходов(/*ИменаДополнительныхТипов*/)
		{
			//ИменаДополнительныхТипов.Добавить(Тип("ДокументОбъект.ВводРаспределенияЗаработкаРаботников"));
			//ИменаДополнительныхТипов.Добавить(Тип("ДокументОбъект.ОтражениеЗарплатыВУпрУчете"));
		}
	}
}
