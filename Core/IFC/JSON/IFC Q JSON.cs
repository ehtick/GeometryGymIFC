// MIT License
// Copyright (c) 2016 Geometry Gym Pty Ltd

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial 
// portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
// LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Linq;
using GeometryGym.STEP;

#if (NET || !NOIFCJSON)
#if (NEWTONSOFT)
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonObject = Newtonsoft.Json.Linq.JObject;
using JsonArray = Newtonsoft.Json.Linq.JArray;
#else
using System.Text.Json.Nodes;
#endif

namespace GeometryGym.Ifc
{
	public partial class IfcQuantityArea
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			AreaValue = extractDouble(obj["AreaValue"]);
			Formula = extractString( obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["AreaValue"] = AreaValue;
			base.setAttribute(obj, "Formula", Formula);
		}

	}
	public partial class IfcQuantityCount
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			CountValueDouble = extractDouble(obj["CountValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["CountValue"] = CountValue;
			base.setAttribute(obj, "Formula", Formula);
		}

	}
	public partial class IfcQuantityLength
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			LengthValue = extractDouble(obj["LengthValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["LengthValue"] = LengthValue;
			base.setAttribute(obj, "Formula", Formula);
		}
	}
	public partial class IfcQuantityNumber
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			NumberValue = extractDouble(obj["NumberValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["NumberValue"] = NumberValue;
			base.setAttribute(obj, "Formula", Formula);
		}
	}
	public partial class IfcQuantityTime 
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			TimeValue = extractDouble(obj["TimeValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["TimeValue"] = TimeValue;
			base.setAttribute(obj, "Formula", Formula);
		}

	}
	public partial class IfcQuantityVolume : IfcPhysicalSimpleQuantity
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			VolumeValue = extractDouble(obj["VolumeValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["VolumeValue"] = VolumeValue;
			base.setAttribute(obj, "Formula", Formula);
		}

	}
	public partial class IfcQuantityWeight 
	{
		internal override void parseJsonObject(JsonObject obj)
		{
			base.parseJsonObject(obj);
			WeightValue = extractDouble(obj["WeightValue"]);
			Formula = extractString(obj["Formula"]);
		}
		protected override void setJSON(JsonObject obj, BaseClassIfc host, SetJsonOptions options)
		{
			base.setJSON(obj, host, options);
			obj["WeightValue"] = WeightValue;
			base.setAttribute(obj, "Formula", Formula);
		}
	}
}
#endif
