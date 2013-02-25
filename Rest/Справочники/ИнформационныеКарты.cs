﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//InformacionnyeKarty
	[Маршрут("Справочники/ИнформационныеКарты","")]
	public class ИнформационныеКартыЗапрос: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыЗапрос>
	{
	}
	[Маршрут("Справочники/ИнформационныеКарты/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ИнформационныеКарты/ПоСсылке","{Ссылка}")]
	public class ИнформационныеКартыНайтиПоСсылке: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ИнформационныеКарты/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ИнформационныеКарты/ПоКоду","{Код}")]
	public class ИнформационныеКартыНайтиПоКоду: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ИнформационныеКарты/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ИнформационныеКарты/ПоНаименованию","{Наименование}")]
	public class ИнформационныеКартыНайтиПоНаименованию: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнформационныеКартыВыбратьПоСсылке: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнформационныеКартыВыбратьПоКоду: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИнформационныеКарты/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ИнформационныеКартыВыбратьПоНаименованию: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИнформационныеКарты/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИнформационныеКартыСтраницаПоСсылке: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ИнформационныеКарты/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ИнформационныеКартыСтраницаПоКоду: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ИнформационныеКарты/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ИнформационныеКартыСтраницаПоНаименованию: V82.СправочникиСсылка.ИнформационныеКарты,IReturn<ИнформационныеКартыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИнформационныеКартыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИнформационныеКартыСервис : Service
	{
		
		public object Get(ИнформационныеКартыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ИнформационныеКарты.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ИнформационныеКартыОтвет() {Ответ = "ИнформационныеКарты c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИнформационныеКартыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ИнформационныеКарты.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИнформационныеКартыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ИнформационныеКартыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ИнформационныеКартыЗапрос Запрос)
		{
			return new ИнформационныеКартыОтвет {Ответ = "ИнформационныеКарты, "};
		}

		public object Post(ИнформационныеКартыЗапрос ЗапросИнформационныеКарты)
		{
			var Ссылка = (СправочникиСсылка.ИнформационныеКарты)ЗапросИнформационныеКарты;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}