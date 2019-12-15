'use strict';

const DEBUG = false;

const expression = "(X ∧ ¬Y ⊕ Z) | ((X -> ¬Z) <-> Y)";

function and(a, b)
{
	const result = (a && b) ? 1 : 0;

	if (DEBUG)
		console.log(`AND(${a}, ${b}) = ${result}`);

	return result;
}

function not(a)
{
	const result = (!a) ? 1 : 0;
	
	if (DEBUG)
		console.log(`NOT(${a}, ${b}) = ${result}`);
	
	return result;
}

function xor(a, b)
{
	const result = !((a && b) || ((!a) && (!b))) ? 1 : 0;

	if (DEBUG)
		console.log(`XOR(${a}, ${b}) = ${result}`);

	return result;
}

function imply(a, b)
{
	const result = (a && (!b)) ? 0 : 1;
	
	if (DEBUG)
		console.log(`IMPLY(${a}, ${b}) = ${result}`);
	
	return result;
}

function eq(a, b)
{
	const result = a === b ? 1 : 0;
	
	if (DEBUG)
		console.log(`EQ(${a}, ${b}) = ${result}`);
	
	return result;
}

function nand(a, b)
{
	const result = !(a && b) ? 1 : 0;
	
	if (DEBUG)
		console.log(`NAND(${a}, ${b}) = ${result}`);
	
	return result;
}

const binaryBooleanFunctions = [
	{char: "∧", proc: and},
	{char: "⊕", proc: xor},
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
	expr = replaceAll(expr, "¬0", "1");
	expr = replaceAll(expr, "¬1", "0");

	for (const f of binaryBooleanFunctions) {
		if (DEBUG)
			console.log(expr);

		expr = replaceAll(expr, `(\\d)${f.char}(\\d)`, function (match, a, b, offset, string) {
			return f.proc(Number(a), Number(b));
		});

		/* Remove unused parenthesis. */
		expr = replaceAll(expr, "\\((\\d)\\)", "$1");
	}
	
	if (DEBUG)
		console.log(" ");

	return expr;
}

function createTruthTableForThreeVariables(expression)
{
	let result = "X Y Z F\n";
	result +=    "-------";

	for (let x = 0; x < 2; ++x) {
		for (let y = 0; y < 2; ++y) {
			for (let z = 0; z < 2; ++z) {
				const variables = [
					["X", x],
					["Y", y],
					["Z", z]
				];

				result += `\n${x} ${y} ${z} ${calculateExpression(expression, variables)}`;
			}
		}
	}

	return result;
}

function createCnfForThreeVariables(truthTableAsString)
{
	let cnf = function (x, y, z) {
		let result = "";

		result += ((x === '1') ? "¬X" : "X") + " ∨ ";
		result += ((y === '1') ? "¬Y" : "Y") + " ∨ ";
		result += (z === '1') ? "¬Z" : "Z";

		return result;
	};

	let result = "";

	let truthTable = truthTableAsString.split('\n');
	
	for (let i = 0; i < truthTable.length; ++i)
		truthTable[i] = truthTable[i].split(' ');

	for (let line of truthTable) {
		if (line[3] === '0')
			result += "(" + cnf(line[0], line[1], line[2]) + ") ∧ ";
	}

	result = result.slice(0, result.length - 2);

	return result;
}

function createDnfForThreeVariables(truthTableAsString)
{
	let cnf = function (x, y, z) {
		let result = "";

		result += ((x === '0') ? "¬X" : "X") + " ∧ ";
		result += ((y === '0') ? "¬Y" : "Y") + " ∧ ";
		result += (z === '0') ? "¬Z" : "Z";

		return result;
	};

	let result = "";

	let truthTable = truthTableAsString.split('\n');
	
	for (let i = 0; i < truthTable.length; ++i)
		truthTable[i] = truthTable[i].split(' ');

	for (let line of truthTable) {
		if (line[3] === '1')
			result += "(" + cnf(line[0], line[1], line[2]) + ") ∨ ";
	}

	result = result.slice(0, result.length - 2);

	return result;
}

let truthTable = createTruthTableForThreeVariables(expression);
console.log(truthTable);
console.log("\nСКНФ: " + createCnfForThreeVariables(truthTable));
console.log("СДНФ: " + createDnfForThreeVariables(truthTable));
