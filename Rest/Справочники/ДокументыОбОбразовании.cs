﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//DokumentyObObrazovanii
	[Маршрут("Справочники/ДокументыОбОбразовании","")]
	public class ДокументыОбОбразованииЗапрос: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииЗапрос>
	{
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ПоСсылке","{Ссылка}")]
	public class ДокументыОбОбразованииНайтиПоСсылке: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ПоКоду","{Код}")]
	public class ДокументыОбОбразованииНайтиПоКоду: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ПоНаименованию","{Наименование}")]
	public class ДокументыОбОбразованииНайтиПоНаименованию: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДокументыОбОбразованииВыбратьПоСсылке: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДокументыОбОбразованииВыбратьПоКоду: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ДокументыОбОбразовании/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДокументыОбОбразованииВыбратьПоНаименованию: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДокументыОбОбразованииСтраницаПоСсылке: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ДокументыОбОбразованииСтраницаПоКоду: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ДокументыОбОбразовании/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ДокументыОбОбразованииСтраницаПоНаименованию: V82.СправочникиСсылка.ДокументыОбОбразовании,IReturn<ДокументыОбОбразованииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДокументыОбОбразованииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ДокументыОбОбразованииСервис : Service
	{
		
		public object Get(ДокументыОбОбразованииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ДокументыОбОбразовании.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДокументыОбОбразованииОтвет() {Ответ = "ДокументыОбОбразовании c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДокументыОбОбразованииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ДокументыОбОбразовании.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ДокументыОбОбразованииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДокументыОбОбразованииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДокументыОбОбразованииЗапрос Запрос)
		{
			return new ДокументыОбОбразованииОтвет {Ответ = "ДокументыОбОбразовании, "};
		}

		public object Post(ДокументыОбОбразованииЗапрос ЗапросДокументыОбОбразовании)
		{
			var Ссылка = (СправочникиСсылка.ДокументыОбОбразовании)ЗапросДокументыОбОбразовании;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}