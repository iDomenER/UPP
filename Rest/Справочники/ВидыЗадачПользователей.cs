﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyZadachPolzovatelejj
	[Маршрут("Справочники/ВидыЗадачПользователей","")]
	public class ВидыЗадачПользователейЗапрос: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ПоСсылке","{Ссылка}")]
	public class ВидыЗадачПользователейНайтиПоСсылке: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ПоКоду","{Код}")]
	public class ВидыЗадачПользователейНайтиПоКоду: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ПоНаименованию","{Наименование}")]
	public class ВидыЗадачПользователейНайтиПоНаименованию: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗадачПользователейВыбратьПоСсылке: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗадачПользователейВыбратьПоКоду: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЗадачПользователей/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЗадачПользователейВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыЗадачПользователейСтраницаПоСсылке: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыЗадачПользователейСтраницаПоКоду: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЗадачПользователей/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыЗадачПользователейСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыЗадачПользователей,IReturn<ВидыЗадачПользователейСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыЗадачПользователейОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыЗадачПользователейСервис : Service
	{
		
		public object Get(ВидыЗадачПользователейЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейНайтиПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыЗадачПользователей.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыЗадачПользователейОтвет() {Ответ = "ВидыЗадачПользователей c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыЗадачПользователейНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыЗадачПользователей.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыЗадачПользователейВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЗадачПользователейСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыЗадачПользователейЗапрос Запрос)
		{
			return new ВидыЗадачПользователейОтвет {Ответ = "ВидыЗадачПользователей, "};
		}

		public object Post(ВидыЗадачПользователейЗапрос ЗапросВидыЗадачПользователей)
		{
			var Ссылка = (СправочникиСсылка.ВидыЗадачПользователей)ЗапросВидыЗадачПользователей;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}