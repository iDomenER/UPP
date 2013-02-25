﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//DenezhnyeDokumenty
	[Маршрут("Справочники/ДенежныеДокументы","")]
	public class ДенежныеДокументыЗапрос: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыЗапрос>
	{
	}
	[Маршрут("Справочники/ДенежныеДокументы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ДенежныеДокументы/ПоСсылке","{Ссылка}")]
	public class ДенежныеДокументыНайтиПоСсылке: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ДенежныеДокументы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ДенежныеДокументы/ПоКоду","{Код}")]
	public class ДенежныеДокументыНайтиПоКоду: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ДенежныеДокументы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ДенежныеДокументы/ПоНаименованию","{Наименование}")]
	public class ДенежныеДокументыНайтиПоНаименованию: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДенежныеДокументыВыбратьПоСсылке: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДенежныеДокументыВыбратьПоКоду: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДенежныеДокументы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДенежныеДокументыВыбратьПоНаименованию: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДенежныеДокументы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДенежныеДокументыСтраницаПоСсылке: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДенежныеДокументы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ДенежныеДокументыСтраницаПоКоду: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДенежныеДокументы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ДенежныеДокументыСтраницаПоНаименованию: V82.СправочникиСсылка.ДенежныеДокументы,IReturn<ДенежныеДокументыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДенежныеДокументыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ДенежныеДокументыСервис : Service
	{
		
		public object Get(ДенежныеДокументыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ДенежныеДокументы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДенежныеДокументыОтвет() {Ответ = "ДенежныеДокументы c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДенежныеДокументыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ДенежныеДокументы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ДенежныеДокументыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДенежныеДокументыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДенежныеДокументыЗапрос Запрос)
		{
			return new ДенежныеДокументыОтвет {Ответ = "ДенежныеДокументы, "};
		}

		public object Post(ДенежныеДокументыЗапрос ЗапросДенежныеДокументы)
		{
			var Ссылка = (СправочникиСсылка.ДенежныеДокументы)ЗапросДенежныеДокументы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}