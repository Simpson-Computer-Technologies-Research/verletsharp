using System;

namespace physics
{
    class Vec3D
    {
        // x, y, and z components of the vector
        public double x;
        public double y;
        public double z;

        // When two vectors are added
        public Vec3D operator +(Vec3D vec)
        {
            return new Vec3D(this.x + vec.x, this.y + vec.y, this.z + vec.z);
        }

        // When two vectors are subtracted
        public Vec3D operator -(Vec3D vec)
        {
            return new Vec3D(this.x - vec.x, this.y - vec.y, this.z - vec.z);
        }

        // When a vector is multiplied by a scalar
        public Vec3D Mult(double scalar)
        {
            return new Vec3D(this.x * scalar, this.y * scalar, this.z * scalar);
        }

        // When a vector is divided by a scalar
        public Vec3D Div(double scalar)
        {
            return new Vec3D(this.x / scalar, this.y / scalar, this.z / scalar);
        }

        // When a vector is held to the power of a scalar
        public Vec3D Pow(double scalar)
        {
            return new Vec3D(Math.Pow(this.x, scalar), Math.Pow(this.y, scalar), Math.Pow(this.z, scalar));
        }

        // Add a scalar
        public Vec3D AddScalar(double b)
        {
            return new Vec3D(this.x + b, this.y + b, this.z + b);
        }

        // Subtract a scalar
        public Vec3D SubScalar(double b)
        {
            return new Vec3D(this.x - b, this.y - b, this.z - b);
        }

        // Multiply by a vector
        public Vec3D MultVector(Vec3D vec)
        {
            return new Vec3D(this.x * vec.x, this.y * vec.y, this.z * vec.z);
        }

        // Copy the vector
        public Vec3D Copy()
        {
            return new Vec3D(this.x, this.y, this.z);
        }

        // Get the vector
        public (double, double, double) Get()
        {
            return (this.x, this.y, this.z);
        }

        // Vector magnitude
        public double Magnitude()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        // Dot product of two vectors
        public double Dot(Vec3D vec)
        {
            return this.x * vec.x + this.y * vec.y + this.z * vec.z;
        }
    }
}
