﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ТипыПериодическихЗадачРаботника
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"edf6440a-ab4e-4c47-bfe0-ef3e7c40dd37\", \"Представление\":\"ОтпускЕжегодный\"}")]
		ОтпускЕжегодный = 0,//Отпуск ежегодный
		[EnumMember(Value = "{\"Ссылка\":\"7bc81655-78ca-4c81-97ff-ddd5b7366165\", \"Представление\":\"Отсутствие\"}")]
		Отсутствие = 1,
		[EnumMember(Value = "{\"Ссылка\":\"fef5e804-5909-4676-b3a8-08a99131d38c\", \"Представление\":\"Мероприятие\"}")]
		Мероприятие = 2,
		[EnumMember(Value = "{\"Ссылка\":\"ebf763c0-051d-4795-929c-966756487281\", \"Представление\":\"ВстречаСКандидатом\"}")]
		ВстречаСКандидатом = 3,//Встреча с кандидатом
		[EnumMember(Value = "{\"Ссылка\":\"4ee98f7b-254e-4818-b4a5-035a49c7d0e1\", \"Представление\":\"Свободен\"}")]
		Свободен = 4,
		[EnumMember(Value = "{\"Ссылка\":\"42953210-3220-4d8f-8e8e-3b8262875fbd\", \"Представление\":\"Встреча\"}")]
		Встреча = 5,
	}
	public static partial class ТипыПериодическихЗадачРаботника_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОтпускЕжегодный = new Guid("3eefe0bf-407c-37dd-4c47-ab4eedf6440a");//Отпуск ежегодный
		public static readonly Guid Отсутствие = new Guid("d5ddff97-36b7-6561-4c81-78ca7bc81655");
		public static readonly Guid Мероприятие = new Guid("a908a8b3-3191-8cd3-4676-5909fef5e804");
		public static readonly Guid ВстречаСКандидатом = new Guid("67969c92-4856-8172-4795-051debf763c0");//Встреча с кандидатом
		public static readonly Guid Свободен = new Guid("5a03a5b4-c749-e1d0-4818-254e4ee98f7b");
		public static readonly Guid Встреча = new Guid("823b8e8e-8762-bd5f-4d8f-322042953210");
		public static ТипыПериодическихЗадачРаботника Получить(this ТипыПериодическихЗадачРаботника Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыПериодическихЗадачРаботника Получить(this ТипыПериодическихЗадачРаботника Значение, Guid Ссылка)
		{
			if(Ссылка == ОтпускЕжегодный)
			{
				return ТипыПериодическихЗадачРаботника.ОтпускЕжегодный;
			}
			else if(Ссылка == Отсутствие)
			{
				return ТипыПериодическихЗадачРаботника.Отсутствие;
			}
			else if(Ссылка == Мероприятие)
			{
				return ТипыПериодическихЗадачРаботника.Мероприятие;
			}
			else if(Ссылка == ВстречаСКандидатом)
			{
				return ТипыПериодическихЗадачРаботника.ВстречаСКандидатом;
			}
			else if(Ссылка == Свободен)
			{
				return ТипыПериодическихЗадачРаботника.Свободен;
			}
			else if(Ссылка == Встреча)
			{
				return ТипыПериодическихЗадачРаботника.Встреча;
			}
			return ТипыПериодическихЗадачРаботника.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыПериодическихЗадачРаботника Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыПериодическихЗадачРаботника Значение)
		{
			switch (Значение)
			{
				case ТипыПериодическихЗадачРаботника.ОтпускЕжегодный: return ОтпускЕжегодный;
				case ТипыПериодическихЗадачРаботника.Отсутствие: return Отсутствие;
				case ТипыПериодическихЗадачРаботника.Мероприятие: return Мероприятие;
				case ТипыПериодическихЗадачРаботника.ВстречаСКандидатом: return ВстречаСКандидатом;
				case ТипыПериодическихЗадачРаботника.Свободен: return Свободен;
				case ТипыПериодическихЗадачРаботника.Встреча: return Встреча;
			}
			return Guid.Empty;
		}
	}
}