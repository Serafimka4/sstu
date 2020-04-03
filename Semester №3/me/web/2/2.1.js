"use strict";

class Vector {
	constructor(x, y, z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	static Sum(a, b)
	{
		return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
	}

	static Difference(a, b)
	{
		return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
	}

	length()
	{
		return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
	}

	toString()
	{
		return `[${this.x}, ${this.y}, ${this.z}]`;
	}
}
