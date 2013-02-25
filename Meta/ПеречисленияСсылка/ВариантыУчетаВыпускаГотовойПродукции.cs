﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВариантыУчетаВыпускаГотовойПродукции
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"fd7d4bd4-a3b6-4e68-9ece-f32bd2a106cb\", \"Представление\":\"СИспользованиемСчета40\"}")]
		СИспользованиемСчета40 = 0,//С использованием счета 40
		[EnumMember(Value = "{\"Ссылка\":\"2939ddd9-9465-48c0-8753-2968cc2c8b79\", \"Представление\":\"БезИспользованияСчета40\"}")]
		БезИспользованияСчета40 = 1,//Без использования счета 40
	}
	public static partial class ВариантыУчетаВыпускаГотовойПродукции_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СИспользованиемСчета40 = new Guid("2bf3ce9e-a1d2-cb06-4e68-a3b6fd7d4bd4");//С использованием счета 40
		public static readonly Guid БезИспользованияСчета40 = new Guid("68295387-2ccc-798b-48c0-94652939ddd9");//Без использования счета 40
		public static ВариантыУчетаВыпускаГотовойПродукции Получить(this ВариантыУчетаВыпускаГотовойПродукции Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыУчетаВыпускаГотовойПродукции Получить(this ВариантыУчетаВыпускаГотовойПродукции Значение, Guid Ссылка)
		{
			if(Ссылка == СИспользованиемСчета40)
			{
				return ВариантыУчетаВыпускаГотовойПродукции.СИспользованиемСчета40;
			}
			else if(Ссылка == БезИспользованияСчета40)
			{
				return ВариантыУчетаВыпускаГотовойПродукции.БезИспользованияСчета40;
			}
			return ВариантыУчетаВыпускаГотовойПродукции.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыУчетаВыпускаГотовойПродукции Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыУчетаВыпускаГотовойПродукции Значение)
		{
			switch (Значение)
			{
				case ВариантыУчетаВыпускаГотовойПродукции.СИспользованиемСчета40: return СИспользованиемСчета40;
				case ВариантыУчетаВыпускаГотовойПродукции.БезИспользованияСчета40: return БезИспользованияСчета40;
			}
			return Guid.Empty;
		}
	}
}