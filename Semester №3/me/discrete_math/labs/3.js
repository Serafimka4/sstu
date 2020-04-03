'use strict';

function conjunction(a, b)
{
	const result = (a && b) ? 1 : 0;

	if (DEBUG)
		console.log(`conjunction(${a}, ${b}) = ${result}`);

	return result;
}

function Negation(a)
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

function Implication(a, b)
{
	const result = (a && (!b)) ? 0 : 1;
	
	if (DEBUG)
		console.log(`Implication(${a}, ${b}) = ${result}`);
	
	return result;
}

function Equivalence(a, b)
{
	const result = a === b ? 1 : 0;
	
	if (DEBUG)
		console.log(`Equivalence(${a}, ${b}) = ${result}`);
	
	return result;
}

function Sheffer(a, b)
{
	const result = !(a && b) ? 1 : 0;
	
	if (DEBUG)
		console.log(`Sheffer(${a}, ${b}) = ${result}`);
	
	return result;
}

const binaryBooleanFunctions = [
	{char: "∧", proc: conjunction},
	{char: "⊕", proc: xor},
	{char: "->", proc: Implication},
	{char: "<->", proc: Equivalence},
	{char: "\\|", proc: Sheffer}
];

function calc(expression, variables)
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

function truth_table(expression)
{
	let result = "X Y Z R\n";
	result +=    "-------";

	for (let x = 0; x < 2; ++x) {
		for (let y = 0; y < 2; ++y) {
			for (let z = 0; z < 2; ++z) {
				const variables = [
					["X", x],
					["Y", y],
					["Z", z]
				];

				result += `\n${x} ${y} ${z} ${calc(expression, variables)}`;
			}
		}
	}

	return result;
}

function cnf(truthTableAsString)
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

function dnf(truthTableAsString)
{
	let cnf = function (x, y, z) {
		let result = "";

		result += (x === '0' ? "¬" : "") + "X";
		result += (y === '0' ? "¬" : "") + "Y";
		result += (z === '0' ? "¬" : "") + "Z";

		return result;
	};

	let result = "";
	let truthTable = truthTableAsString.split('\n');
	
	for (let i = 0; i < truthTable.length; ++i)
		truthTable[i] = truthTable[i].split(' ');

	for (let line of truthTable) {
		if (line[3] === '1')
			result += cnf(line[0], line[1], line[2]) + " ∨ ";
	}

	result = result.slice(0, result.length - 2);

	return result;
}

const DEBUG = true;
let truthTable = truth_table("(X ∧ ¬Y ⊕ Z) | ((X -> ¬Z) <-> Y)");
console.log(truthTable);
console.log("\nСКНФ: " + cnf(truthTable));
console.log("СДНФ: " + dnf(truthTable));
