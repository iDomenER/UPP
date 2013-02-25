﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыМедицинскогоСтрахования
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"3d6103d8-556d-4142-86a2-ee3d42062111\", \"Представление\":\"Обязательное\"}")]
		Обязательное = 0,
		[EnumMember(Value = "{\"Ссылка\":\"6c2ea03e-146a-4703-a461-464e3dd6d5d4\", \"Представление\":\"Добровольное\"}")]
		Добровольное = 1,
	}
	public static partial class ВидыМедицинскогоСтрахования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Обязательное = new Guid("3deea286-0642-1121-4142-556d3d6103d8");
		public static readonly Guid Добровольное = new Guid("4e4661a4-d63d-d4d5-4703-146a6c2ea03e");
		public static ВидыМедицинскогоСтрахования Получить(this ВидыМедицинскогоСтрахования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыМедицинскогоСтрахования Получить(this ВидыМедицинскогоСтрахования Значение, Guid Ссылка)
		{
			if(Ссылка == Обязательное)
			{
				return ВидыМедицинскогоСтрахования.Обязательное;
			}
			else if(Ссылка == Добровольное)
			{
				return ВидыМедицинскогоСтрахования.Добровольное;
			}
			return ВидыМедицинскогоСтрахования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыМедицинскогоСтрахования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыМедицинскогоСтрахования Значение)
		{
			switch (Значение)
			{
				case ВидыМедицинскогоСтрахования.Обязательное: return Обязательное;
				case ВидыМедицинскогоСтрахования.Добровольное: return Добровольное;
			}
			return Guid.Empty;
		}
	}
}