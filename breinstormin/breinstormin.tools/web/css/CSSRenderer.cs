using System;
using System.Collections.Generic;
using System.Text;

namespace breinstormin.tools.web.css {
	public static class CSSRenderer {
        public static string Render(Model.CSSDocument css)
        {
			StringBuilder txt = new StringBuilder();
			//foreach (Import imp in css.Imports) {
			//    txt.AppendFormat("{0}\r\n", imp.ToString());
			//}
			//foreach (Media mtg in css.Medias) {
			//    txt.AppendFormat("@media{0} {{\r\n", mtg.Media != Media.None ? " " + mtg.Media.ToString() : "");
			//    foreach (Selector sel in mtg.Selectors) {
			//        txt.Append(Render(sel, 1));
			//        txt.Append("\r\n");
			//    }
			//    txt.Append("}\r\n");
			//}
			//foreach (Selector sel in css.Selectors) {
			//    txt.Append(Render(sel));
			//    txt.Append("\r\n");
			//}
			txt.Append(css.ToString());
			return txt.ToString();
		}

		//public static string Render(Selector sel) {
		//    return Render(sel, 0);
		//}

		//private static string Render(Selector sel, int nesting) {
		//    string prefix = "";
		//    for (int i = 0; i < nesting; i++) {
		//        prefix += "\t";
		//    }
		//    StringBuilder txt = new StringBuilder();

		//    bool first = true;
		//    foreach (Tag t in sel.Tags) {
		//        if (first) {
		//            first = false;
		//            txt.Append(prefix);
		//        } else {
		//            txt.Append(", ");
		//        }
		//        txt.Append(t.ToString());
		//    }
		//    txt.Append(" {\r\n");
		//    foreach (Property prp in sel.Properties) {
		//        txt.Append("\t");
		//        txt.Append(prefix);
		//        txt.Append(prp.Attribute);
		//        txt.Append(": ");

		//        bool pfirst = true;
		//        foreach (PropertyValue pv in prp.Values) {
		//            if (pfirst) { pfirst = false; } else { txt.Append(" "); }
		//            if (pv.Type == breinstormin.tools.web.css.ValueType.Url) {
		//                txt.Append("url(");
		//            } else if (pv.Type == breinstormin.tools.web.css.ValueType.Hex && !pv.Value.StartsWith("#")) {
		//                txt.Append("#");
		//            }
		//            txt.Append(pv.Value);
		//            if (pv.Type == breinstormin.tools.web.css.ValueType.Unit) {
		//                txt.Append(pv.Unit.ToString().ToLower());
		//            } else if (pv.Type == breinstormin.tools.web.css.ValueType.Percent) {
		//                txt.Append("%");
		//            } else if (pv.Type == breinstormin.tools.web.css.ValueType.Url) {
		//                txt.Append(")");
		//            }
		//        }
		//        if (prp.Important) {
		//            txt.Append(" !important");
		//        }
		//        txt.Append(";\r\n");
		//    }
		//    txt.AppendFormat("{0}}}", prefix);

		//    return txt.ToString();
		//}
	}
}