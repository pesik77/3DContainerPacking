using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CromulentBisgetti.ContainerPacking.Algorithms {
	[DataContract]
	public enum AlgorithmType {
		/// <summary>
		/// The EB-AFIT packing algorithm type.
		/// </summary>
		[DataMember]
		EB_AFIT = 1,
		/// <summary>
		/// The EB-AFIT-EX packing algorithm type with extra conditions.
		/// </summary>
		[DataMember]
		EB_AFIT_EX = 2
	}
}