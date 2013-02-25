﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Регл)
	///</summary>
	[DataContract]
	public enum ОтношениеКВоинскойОбязанности
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"5d61089d-00b8-48da-9694-cc9ac0f409e2\", \"Представление\":\"Военнообязанный\"}")]
		Военнообязанный = 0,
		[EnumMember(Value = "{\"Ссылка\":\"cd1c8304-7bcb-4681-a787-bf30954902d8\", \"Представление\":\"НеВоеннообязанный\"}")]
		НеВоеннообязанный = 1,//Не военнообязанный
		[EnumMember(Value = "{\"Ссылка\":\"a658babd-44a3-482b-85a2-905d1b655ff3\", \"Представление\":\"Призывник\"}")]
		Призывник = 2,
	}
	public static partial class ОтношениеКВоинскойОбязанности_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Военнообязанный = new Guid("9acc9496-f4c0-e209-48da-00b85d61089d");
		public static readonly Guid НеВоеннообязанный = new Guid("30bf87a7-4995-d802-4681-7bcbcd1c8304");//Не военнообязанный
		public static readonly Guid Призывник = new Guid("5d90a285-651b-f35f-482b-44a3a658babd");
		public static ОтношениеКВоинскойОбязанности Получить(this ОтношениеКВоинскойОбязанности Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОтношениеКВоинскойОбязанности Получить(this ОтношениеКВоинскойОбязанности Значение, Guid Ссылка)
		{
			if(Ссылка == Военнообязанный)
			{
				return ОтношениеКВоинскойОбязанности.Военнообязанный;
			}
			else if(Ссылка == НеВоеннообязанный)
			{
				return ОтношениеКВоинскойОбязанности.НеВоеннообязанный;
			}
			else if(Ссылка == Призывник)
			{
				return ОтношениеКВоинскойОбязанности.Призывник;
			}
			return ОтношениеКВоинскойОбязанности.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОтношениеКВоинскойОбязанности Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОтношениеКВоинскойОбязанности Значение)
		{
			switch (Значение)
			{
				case ОтношениеКВоинскойОбязанности.Военнообязанный: return Военнообязанный;
				case ОтношениеКВоинскойОбязанности.НеВоеннообязанный: return НеВоеннообязанный;
				case ОтношениеКВоинскойОбязанности.Призывник: return Призывник;
			}
			return Guid.Empty;
		}
	}
}