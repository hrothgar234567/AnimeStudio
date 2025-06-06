﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AnimeStudio
{
	public static class ArrayYAMLExtensions
	{
		public static YAMLNode ExportYAML(this byte[] _this)
		{
			StringBuilder sb = new StringBuilder(_this.Length * 2);
			for (int i = 0; i < _this.Length; i++)
			{
				sb.AppendHex(_this[i]);
			}
			return new YAMLScalarNode(sb.ToString(), true);
		}

        public static YAMLNode ExportYAML<T>(this T[][] _this, int[] version)
			where T : IYAMLExportable
		{
            return ((IEnumerable<IEnumerable<T>>)_this).ExportYAML(version);
        }
    }
}
