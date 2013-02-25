﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TekhnologicheskieOperacii
	[Маршрут("Справочники/ТехнологическиеОперации","")]
	public class ТехнологическиеОперацииЗапрос: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииЗапрос>
	{
	}
	[Маршрут("Справочники/ТехнологическиеОперации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ПоСсылке","{Ссылка}")]
	public class ТехнологическиеОперацииНайтиПоСсылке: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТехнологическиеОперации/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ПоКоду","{Код}")]
	public class ТехнологическиеОперацииНайтиПоКоду: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТехнологическиеОперации/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ПоНаименованию","{Наименование}")]
	public class ТехнологическиеОперацииНайтиПоНаименованию: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТехнологическиеОперацииВыбратьПоСсылке: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТехнологическиеОперацииВыбратьПоКоду: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТехнологическиеОперации/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТехнологическиеОперацииВыбратьПоНаименованию: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТехнологическиеОперации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТехнологическиеОперацииСтраницаПоСсылке: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТехнологическиеОперации/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТехнологическиеОперацииСтраницаПоКоду: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТехнологическиеОперации/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТехнологическиеОперацииСтраницаПоНаименованию: V82.СправочникиСсылка.ТехнологическиеОперации,IReturn<ТехнологическиеОперацииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТехнологическиеОперацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТехнологическиеОперацииСервис : Service
	{
		
		public object Get(ТехнологическиеОперацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ТехнологическиеОперации.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТехнологическиеОперацииОтвет() {Ответ = "ТехнологическиеОперации c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ТехнологическиеОперацииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ТехнологическиеОперации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ТехнологическиеОперацииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТехнологическиеОперацииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТехнологическиеОперацииЗапрос Запрос)
		{
			return new ТехнологическиеОперацииОтвет {Ответ = "ТехнологическиеОперации, "};
		}

		public object Post(ТехнологическиеОперацииЗапрос ЗапросТехнологическиеОперации)
		{
			var Ссылка = (СправочникиСсылка.ТехнологическиеОперации)ЗапросТехнологическиеОперации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}