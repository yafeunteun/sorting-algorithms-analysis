﻿using System;
using GUI.Models;

namespace GUI.Algorithms
{
	public class Sorter
	{
		public SortingStrategy sortingStrategy { get; set;}

		public Sorter ()
		{
		}


		public Probe Sort(DataSet dataset, int beginIndex, int endIndex) {

			return this.sortingStrategy.doAlgorithm (dataset, beginIndex, endIndex);
		}

	}
}

