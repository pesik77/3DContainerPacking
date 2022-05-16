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
		/// The EB-AFIT-HR packing algorithm type with only horizontal rotation.
		/// </summary>
		[DataMember]
		EB_AFIT_HR = 2
	}
}