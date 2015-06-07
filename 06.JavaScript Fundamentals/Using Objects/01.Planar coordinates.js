function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        throw  new Error('X and Y should be numbers.');
    }

    if (!(this instanceof Point)) {
        return new Point(x, y);
    }

    this.x = x;
    this.y = y;
}

function Line(p1, p2) {
    if (!(p1 instanceof Point) || !(p2 instanceof Point)) {
        throw new Error("P1 and P2 should be instances of Point");
    }

    if (!(this instanceof Line)) {
        return new Line(p1, p2);
    }

    this.p1 = p1;
    this.p2 = p2;
}

Line.prototype.getDistance = function() {
    var x = (this.p1.x - this.p2.x) * (this.p1.x - this.p2.x);
    var y = (this.p1.y - this.p2.y) * (this.p1.y - this.p2.y);

    return Math.sqrt(x + y);
};

Point.prototype.toString = function() {
    return 'P(' + this.x + ',' + this.y + ')';
};

Line.prototype.toString = function() {
    return 'L[' + this.p1.toString() + ',' + this.p2.toString() + ']';
};

function canFormTriangle(a, b, c) {
    return a.getDistance() < b.getDistance() + c.getDistance() &&
           b.getDistance() < c.getDistance() + a.getDistance() &&
           c.getDistance() < a.getDistance() + b.getDistance();
}

var pointA = new Point(2, 3),
	pointB = new Point(5, 6),
	pointC = new Point(3, 8),
	lineA = new Line(pointA, pointB),
	lineB = new Line(pointB, pointC),
	lineC = new Line(pointC, pointA);

	console.log('pointA = ' + pointA.toString());
	console.log('pointB = ' + pointB.toString());
	console.log('pointC = ' + pointC.toString());
	console.log('lineA = ' + lineA.toString());
	console.log('lineB = ' + lineB.toString());
	console.log('lineC = ' + lineC.toString());
	console.log('Can form triangle from lineA, lineB and lineC --> '+canFormTriangle(lineA, lineB, lineC));