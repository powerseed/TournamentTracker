﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public class TextConnector : IDataConnection
	{
		public PrizeModel CreatePrize(PrizeModel prizeModel)
		{
			prizeModel.Id = 1;

			return prizeModel;
		}
	}
}
