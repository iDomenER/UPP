﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//DogovorNaVypolnenieRabotSFizLicom
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом","")]
	public class ДоговорНаВыполнениеРаботСФизЛицомЗапрос: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомЗапрос>
	{
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ПоСсылке","{Ссылка}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомНайтиПоСсылке: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ПоНомеру","{Номер}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомНайтиПоНомеру: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоСсылке: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоНомеру: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоСсылке: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ДоговорНаВыполнениеРаботСФизЛицом/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоНомеру: V82.ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом,IReturn<ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДоговорНаВыполнениеРаботСФизЛицомОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ДоговорНаВыполнениеРаботСФизЛицомСервис : Service
	{
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ДоговорНаВыполнениеРаботСФизЛицом.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ДоговорНаВыполнениеРаботСФизЛицомОтвет() { Ответ = "ДоговорНаВыполнениеРаботСФизЛицом c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ДоговорНаВыполнениеРаботСФизЛицом.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ДоговорНаВыполнениеРаботСФизЛицомОтвет() {Ответ = "ДоговорНаВыполнениеРаботСФизЛицом c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ДоговорНаВыполнениеРаботСФизЛицом.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДоговорНаВыполнениеРаботСФизЛицомСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ДоговорНаВыполнениеРаботСФизЛицомЗапрос Запрос)
		{
			return new ДоговорНаВыполнениеРаботСФизЛицомОтвет {Ответ = "ДоговорНаВыполнениеРаботСФизЛицом, "};
		}

		public object Post(ДоговорНаВыполнениеРаботСФизЛицомЗапрос ЗапросДоговорНаВыполнениеРаботСФизЛицом)
		{
			var Ссылка = (ДокументыСсылка.ДоговорНаВыполнениеРаботСФизЛицом)ЗапросДоговорНаВыполнениеРаботСФизЛицом;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}