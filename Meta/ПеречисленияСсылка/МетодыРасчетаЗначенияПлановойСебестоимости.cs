﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum МетодыРасчетаЗначенияПлановойСебестоимости
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"91464d87-487f-468b-8d93-5c2ce9abe8e4\", \"Представление\":\"ПоФактическойСебестоимости\"}")]
		ПоФактическойСебестоимости = 0,//По фактической себестоимости
		[EnumMember(Value = "{\"Ссылка\":\"8acb833b-fbe7-49e7-a699-70ed95f28ba7\", \"Представление\":\"ПоПлановойСебестоимости\"}")]
		ПоПлановойСебестоимости = 1,//По плановой себестоимости
		[EnumMember(Value = "{\"Ссылка\":\"101ba4a0-2936-4c16-bf2c-7720f379758a\", \"Представление\":\"ПоНормативам\"}")]
		ПоНормативам = 2,//По нормативам
		[EnumMember(Value = "{\"Ссылка\":\"37dacbc3-3e95-4193-a74b-ebbe0044ee30\", \"Представление\":\"НеРассчитывать\"}")]
		НеРассчитывать = 3,//Не рассчитывать
	}
	public static partial class МетодыРасчетаЗначенияПлановойСебестоимости_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоФактическойСебестоимости = new Guid("2c5c938d-abe9-e4e8-468b-487f91464d87");//По фактической себестоимости
		public static readonly Guid ПоПлановойСебестоимости = new Guid("ed7099a6-f295-a78b-49e7-fbe78acb833b");//По плановой себестоимости
		public static readonly Guid ПоНормативам = new Guid("20772cbf-79f3-8a75-4c16-2936101ba4a0");//По нормативам
		public static readonly Guid НеРассчитывать = new Guid("beeb4ba7-4400-30ee-4193-3e9537dacbc3");//Не рассчитывать
		public static МетодыРасчетаЗначенияПлановойСебестоимости Получить(this МетодыРасчетаЗначенияПлановойСебестоимости Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МетодыРасчетаЗначенияПлановойСебестоимости Получить(this МетодыРасчетаЗначенияПлановойСебестоимости Значение, Guid Ссылка)
		{
			if(Ссылка == ПоФактическойСебестоимости)
			{
				return МетодыРасчетаЗначенияПлановойСебестоимости.ПоФактическойСебестоимости;
			}
			else if(Ссылка == ПоПлановойСебестоимости)
			{
				return МетодыРасчетаЗначенияПлановойСебестоимости.ПоПлановойСебестоимости;
			}
			else if(Ссылка == ПоНормативам)
			{
				return МетодыРасчетаЗначенияПлановойСебестоимости.ПоНормативам;
			}
			else if(Ссылка == НеРассчитывать)
			{
				return МетодыРасчетаЗначенияПлановойСебестоимости.НеРассчитывать;
			}
			return МетодыРасчетаЗначенияПлановойСебестоимости.ПустаяСсылка;
		}
		public static byte[] Ключ(this МетодыРасчетаЗначенияПлановойСебестоимости Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МетодыРасчетаЗначенияПлановойСебестоимости Значение)
		{
			switch (Значение)
			{
				case МетодыРасчетаЗначенияПлановойСебестоимости.ПоФактическойСебестоимости: return ПоФактическойСебестоимости;
				case МетодыРасчетаЗначенияПлановойСебестоимости.ПоПлановойСебестоимости: return ПоПлановойСебестоимости;
				case МетодыРасчетаЗначенияПлановойСебестоимости.ПоНормативам: return ПоНормативам;
				case МетодыРасчетаЗначенияПлановойСебестоимости.НеРассчитывать: return НеРассчитывать;
			}
			return Guid.Empty;
		}
	}
}