﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Proekty
	[Маршрут("Справочники/Проекты","")]
	public class ПроектыЗапрос: V82.СправочникиСсылка.Проекты,IReturn<ПроектыЗапрос>
	{
	}
	[Маршрут("Справочники/Проекты/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Проекты/ПоСсылке","{Ссылка}")]
	public class ПроектыНайтиПоСсылке: V82.СправочникиСсылка.Проекты,IReturn<ПроектыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Проекты/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Проекты/ПоКоду","{Код}")]
	public class ПроектыНайтиПоКоду: V82.СправочникиСсылка.Проекты,IReturn<ПроектыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Проекты/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Проекты/ПоНаименованию","{Наименование}")]
	public class ПроектыНайтиПоНаименованию: V82.СправочникиСсылка.Проекты,IReturn<ПроектыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Проекты/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПроектыВыбратьПоСсылке: V82.СправочникиСсылка.Проекты,IReturn<ПроектыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Проекты/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПроектыВыбратьПоКоду: V82.СправочникиСсылка.Проекты,IReturn<ПроектыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Проекты/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Проекты/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПроектыВыбратьПоНаименованию: V82.СправочникиСсылка.Проекты,IReturn<ПроектыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Проекты/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПроектыСтраницаПоСсылке: V82.СправочникиСсылка.Проекты,IReturn<ПроектыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Проекты/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПроектыСтраницаПоКоду: V82.СправочникиСсылка.Проекты,IReturn<ПроектыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Проекты/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПроектыСтраницаПоНаименованию: V82.СправочникиСсылка.Проекты,IReturn<ПроектыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПроектыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПроектыСервис : Service
	{
		
		public object Get(ПроектыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Проекты.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПроектыОтвет() {Ответ = "Проекты c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПроектыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Проекты.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПроектыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПроектыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПроектыЗапрос Запрос)
		{
			return new ПроектыОтвет {Ответ = "Проекты, "};
		}

		public object Post(ПроектыЗапрос ЗапросПроекты)
		{
			var Ссылка = (СправочникиСсылка.Проекты)ЗапросПроекты;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}