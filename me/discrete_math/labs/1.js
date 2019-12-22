'use strict';

class Pair {
	constructor(a, b)
	{
		this.a = a;
		this.b = b;
	}

	toString()
	{
		return `(${this.a}, ${this.b})`;
	}

	reverse()
	{
		return new Pair(this.b, this.a);
	}
}

function elementsEquals(a, b)
{
	if (a === b)
		return true;

	if (a.toString() === b.toString())
		return true;

	return false;
}

Set.prototype.containsElement = function(element)
{
	for (const e of this)
		if (elementsEquals(e, element))
			return true;

	return false;
}

function union(a, b)
{
	let c = new Set();

	for (const eA of a)
		c.add(eA);

	for (const eB of b)
		if (!c.containsElement(eB))
			c.add(eB);

	return c;
}

function intersection(a, b)
{
	let c = new Set();

	for (const eA of a)
		for (const eB of b)
			if (elementsEquals(eA, eB))
				c.add(eA);

	return c;
}

function difference(a, b)
{
	let c = new Set();

	for (const eA of a)
		if (!b.containsElement(eA))
			c.add(eA);

	return c;
}

function symmentricDifference(a, b)
{
	return union(difference(a, b), difference(b, a));
}

function cartesianProduct(a, b)
{
	const c = new Set();

	for (const i of a)
		for (const j of b)
			c.add([i, j]);

	return c;
}

function inversion(a)
{
	const b = new Set();

	for (const i of a)
		b.add(i.reverse());

	return b;
}

function composition(a, b)
{
	const c = new Set();

	for (const i of a)
		for (const j of b)
			if (j.a === i.b)
				c.add(new Pair(i.a, j.b));

	return c;
}

let a = new Set([new Pair(1, 'a'), new Pair(2, 'b'), new Pair(3, 'c'), new Pair(4, 'd')]);
let b = new Set([new Pair(3, 'c'), new Pair('a', 13), new Pair('b', 19), new Pair(6, 'f')]);

console.log('A: {' + [...a].join(',') + '}');
console.log('B: {' + [...b].join(',') + '}');
console.log('Union: {' + [...union(a, b)].join(',') + '}');
console.log('Intersection: {' + [...intersection(a, b)].join(',') + '}');
console.log('Difference: {' + [...difference(a, b)].join(',') + '}');
console.log('Symmetric difference: {' + [...symmentricDifference(a, b)].join(',') + '}');
console.log('Cartesian product: {[' + [...cartesianProduct(a, b)].join('] [') + ']}');
console.log('Inversion: {' + [...inversion(a)].join(',') + '}');
console.log('Composition: {' + [...composition(a, b)].join(',') + '}');
