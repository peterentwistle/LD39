namespace AssemblyCSharp {
	
	public interface IPlaceable {
		PlaceableType PlaceableType { get; set; }
		int PowerUsageIdle { get; set; }
		int PowerUsageActive { get; set; }
	}
}
