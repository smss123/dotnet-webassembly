namespace WebAssembly.Instructions
{
	/// <summary>
	/// Sign-agnostic rotate left.
	/// </summary>
	public class Int32RotateLeft : SimpleInstruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int32RotateLeft"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int32RotateLeft;

		/// <summary>
		/// Creates a new  <see cref="Int32RotateLeft"/> instance.
		/// </summary>
		public Int32RotateLeft()
		{
		}
	}
}