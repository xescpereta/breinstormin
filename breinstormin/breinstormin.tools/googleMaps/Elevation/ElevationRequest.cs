﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace breinstormin.tools.googleMaps.Elevation
{
	/// <summary>
	/// Provides a request for the Google Maps Elevation web service.
	/// </summary>
	public class ElevationRequest
	{
		/// <summary>
		/// Defines the location(s) on the earth from which to return elevation
		/// data. This parameter takes either a single location as a
		/// comma-separated {latitude,longitude} pair (e.g. "40.714728,-73.998672")
		/// or multiple latitude/longitude pairs passed as an array or as an
		/// encoded polyline.
		/// </summary>
		/// <remarks>Required if path not present.</remarks>
		/// <see cref="http://code.google.com/apis/maps/documentation/elevation/#Locations"/>
		public string Locations { get; set; }

		/// <summary>
		/// Defines a path on the earth for which to return elevation data.
		/// This parameter defines a set of two or more ordered {latitude,
		/// longitude} pairs defining a path along the surface of the earth.
		/// This parameter must be used in conjunction with the samples
		/// parameter.
		/// </summary>
		/// <remarks>Required if locations not present.</remarks>
		/// <see cref="http://code.google.com/apis/maps/documentation/elevation/#Paths"/>
		public string Path { get; set; }

		/// <summary>
		/// specifies the number of sample points along a path for which to return
		/// elevation data. The samples parameter divides the given path into an
		/// ordered set of equidistant points along the path.
		/// </summary>
		/// <remarks>Required if a path is specified.</remarks>
		public string Samples { get; set; }

		/// <summary>
		/// Specifies whether the application requesting elevation data is
		/// using a sensor to determine the user's location. This parameter
		/// is required for all elevation requests.
		/// </summary>
		/// <remarks>Required.</remarks>
		/// <see cref="http://code.google.com/apis/maps/documentation/elevation/#Sensor"/>
		public string Sensor { get; set; }

		internal Uri ToUri()
		{
			var url = "json?"
				.Append("locations=", Locations)
				.Append("path=", Path)
				.Append("samples=", Samples)
				.Append("sensor=", Sensor)
				.TrimEnd('&');

			return new Uri(url, UriKind.Relative);
		}
	}
}
