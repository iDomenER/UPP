﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//RegistraciyaVIFNS
	[Маршрут("Справочники/РегистрацияВИФНС","")]
	public class РегистрацияВИФНСЗапрос: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСЗапрос>
	{
	}
	[Маршрут("Справочники/РегистрацияВИФНС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ПоСсылке","{Ссылка}")]
	public class РегистрацияВИФНСНайтиПоСсылке: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/РегистрацияВИФНС/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ПоКоду","{Код}")]
	public class РегистрацияВИФНСНайтиПоКоду: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/РегистрацияВИФНС/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ПоНаименованию","{Наименование}")]
	public class РегистрацияВИФНСНайтиПоНаименованию: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class РегистрацияВИФНСВыбратьПоСсылке: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class РегистрацияВИФНСВыбратьПоКоду: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/РегистрацияВИФНС/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class РегистрацияВИФНСВыбратьПоНаименованию: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНСВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/РегистрацияВИФНС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class РегистрацияВИФНССтраницаПоСсылке: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РегистрацияВИФНС/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class РегистрацияВИФНССтраницаПоКоду: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНССтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/РегистрацияВИФНС/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class РегистрацияВИФНССтраницаПоНаименованию: V82.СправочникиСсылка.РегистрацияВИФНС,IReturn<РегистрацияВИФНССтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class РегистрацияВИФНСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class РегистрацияВИФНССервис : Service
	{
		
		public object Get(РегистрацияВИФНСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНСНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНСНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.РегистрацияВИФНС.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new РегистрацияВИФНСОтвет() {Ответ = "РегистрацияВИФНС c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(РегистрацияВИФНСНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.РегистрацияВИФНС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(РегистрацияВИФНСВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНСВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНССтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(РегистрацияВИФНССтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(РегистрацияВИФНСЗапрос Запрос)
		{
			return new РегистрацияВИФНСОтвет {Ответ = "РегистрацияВИФНС, "};
		}

		public object Post(РегистрацияВИФНСЗапрос ЗапросРегистрацияВИФНС)
		{
			var Ссылка = (СправочникиСсылка.РегистрацияВИФНС)ЗапросРегистрацияВИФНС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}