﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЗарплатаКВыплатеСервис
	{
		// Функция возвращает текстовое представление состояния оплаты ведомости
		//
		// Параметры:
		//   ПлатежныеДокументы - массив представлений платежных документами, содержащая колонку "Представление"
		//
		// Возвращаемое значение:
		//		Строка вида "Ведомость <...> оплачена документами <...>"
		//

		public object ТекстовоеПредставлениеОплаты(/*ПлатежныеДокументы, МаксДоковДляПоказа = 3*/)
		{
			//КоличествоДокументов = ПлатежныеДокументы.Количество();
			//ТекстОплаты = "";
			if(true/*КоличествоДокументов > 0*/)
			{
				//ТекстОплаты = ТекстОплаты + "оплачена " + ?(КоличествоДокументов = 1,"документом ", "документами ");
				if(true/*КоличествоДокументов >= МаксДоковДляПоказа*/)
				{
					//ТекстОплаты = ТекстОплаты + "...";
				}
			}
			return null;
		}
	}
}
