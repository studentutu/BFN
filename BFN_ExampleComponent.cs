// src* = https://github.com/andrew-raphael-lukasik/BFN
using UnityEngine;
public class BFN_ExampleComponent : MonoBehaviour
{
	[SerializeField] BFN _a = new BFN{ number=11.2423085208 , exponent=21 };
	[SerializeField] BFN _b = new BFN{ number=12312425.14124312 , exponent=100 };
	[SerializeField] OP _operator = OP.Add;
	[SerializeField] BFN _result = (BFN) 0;

	public enum OP : byte { Add , Subtract , Multiply , Divide }

	#if UNITY_EDITOR
	void OnValidate ()
	{
		switch( _operator )
		{
			case OP.Add:		_result = _a + _b; break;
			case OP.Subtract:	_result = _a - _b; break;
			case OP.Multiply:	_result = _a * _b; break;
			case OP.Divide:		_result = _a / _b; break;
			default: throw new System.NotImplementedException();
		}
	}
	#endif
	
	void Start ()
	{
		Debug.Log($"{_a} {_operator} {_b} = {_result}");
	}

}
