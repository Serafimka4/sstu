"use strict";

function Vector(x, y, z)
{
	this.x = x;
	this.y = y;
	this.z = z;

	return this;
}

Vector.Sum = function(a, b)
{
	return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
}

Vector.Difference = function(a, b)
{
	return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
}

Vector.prototype.length = function()
{
	return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
}

Vector.prototype.toString = function()
{
	return `[${this.x}, ${this.y}, ${this.z}]`;
}
