'use strict';

const expression = "(x && y' ^ z) | ((x -> z') <-> y)";

function and(a, b)
{
	const result = a && b;
	return result === true ? 1 : 0;
}

function not(a)
{
	const result = !a;
	return result === true ? 1 : 0;
}

function xor(a, b)
{
	const result = !((a && b) || ((!a) && (!b)));
	return result === true ? 1 : 0;
}

function imply(a, b)
{
	const result = (a && (!b)) ? false : true;
	return result === true ? 1 : 0;
}

function eq(a, b)
{
	const result = a === b;
	return result === true ? 1 : 0;
}

function nand(a, b)
{
	const result = !(a && b);
	return result === true ? 1 : 0;
}

const binaryBooleanFunctions = [
	{char: "&&", proc: and},
	{char: "\\^", proc: xor},
	{char: "->", proc: imply},
	{char: "<->", proc: eq},
	{char: "\\|", proc: nand}
];

function calculateExpression(expression, variables)
{
	let expr = expression;

	const replaceAll = function(string, search, replacement) {
		return string.replace(new RegExp(search, 'g'), replacement);
	};

	/* Remove all the spaces. */
	expr = replaceAll(expr, " ", "");

	/* Substitute variables values. */
	for (const v of variables)
		expr = replaceAll(expr, v[0], v[1]);
	
	/* Negation. */
	expr = replaceAll(expr, "0'", "1");
	expr = replaceAll(expr, "1'", "0");

	for (const f of binaryBooleanFunctions) {
		expr = replaceAll(expr, `(\\d)${f.char}(\\d)`, function (match, a, b, offset, string) {
			return f.proc(Number(a), Number(b));
		});

		/* Remove unused parenthesis. */
		expr = replaceAll(expr, "\\((\\d)\\)", "$1");
	}

	return expr;
}

function createTruthTableForThreeVariables(expression)
{
	console.log(`X Y Z F`);

	for (let x = 0; x < 2; ++x) {
		for (let y = 0; y < 2; ++y) {
			for (let z = 0; z < 2; ++z) {
				const variables = [
					["x", x],
					["y", y],
					["z", z]
				];

				console.log(`${x} ${y} ${z} ${calculateExpression(expression, variables)}`);
			}
		}
	}
}

createTruthTableForThreeVariables(expression);
