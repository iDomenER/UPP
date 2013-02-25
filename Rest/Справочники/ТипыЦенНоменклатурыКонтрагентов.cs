﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//TipyCenNomenklaturyKontragentov
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов","")]
	public class ТипыЦенНоменклатурыКонтрагентовЗапрос: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовЗапрос>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ПоСсылке","{Ссылка}")]
	public class ТипыЦенНоменклатурыКонтрагентовНайтиПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ПоКоду","{Код}")]
	public class ТипыЦенНоменклатурыКонтрагентовНайтиПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ПоНаименованию","{Наименование}")]
	public class ТипыЦенНоменклатурыКонтрагентовНайтиПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыКонтрагентовВыбратьПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыКонтрагентовВыбратьПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ТипыЦенНоменклатурыКонтрагентовВыбратьПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыКонтрагентовСтраницаПоСсылке: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыКонтрагентовСтраницаПоКоду: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ТипыЦенНоменклатурыКонтрагентов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ТипыЦенНоменклатурыКонтрагентовСтраницаПоНаименованию: V82.СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов,IReturn<ТипыЦенНоменклатурыКонтрагентовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ТипыЦенНоменклатурыКонтрагентовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ТипыЦенНоменклатурыКонтрагентовСервис : Service
	{
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ТипыЦенНоменклатурыКонтрагентов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ТипыЦенНоменклатурыКонтрагентовОтвет() {Ответ = "ТипыЦенНоменклатурыКонтрагентов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ТипыЦенНоменклатурыКонтрагентов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ТипыЦенНоменклатурыКонтрагентовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ТипыЦенНоменклатурыКонтрагентовЗапрос Запрос)
		{
			return new ТипыЦенНоменклатурыКонтрагентовОтвет {Ответ = "ТипыЦенНоменклатурыКонтрагентов, "};
		}

		public object Post(ТипыЦенНоменклатурыКонтрагентовЗапрос ЗапросТипыЦенНоменклатурыКонтрагентов)
		{
			var Ссылка = (СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов)ЗапросТипыЦенНоменклатурыКонтрагентов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}