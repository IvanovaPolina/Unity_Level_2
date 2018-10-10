﻿namespace Homework.Data
{
	public struct GameObjectData
	{
		public string name;
		public float HP;
		public Vector3 position;
		public Quaternion quaternion;
		public Vector3 scale;

		[System.Serializable]
		public struct Vector3
		{
			public float x;
			public float y;
			public float z;

			public Vector3(float x, float y, float z) {
				this.x = x;
				this.y = y;
				this.z = z;
			}

			public static implicit operator UnityEngine.Vector3(GameObjectData.Vector3 value) {
				return new Vector3(value.x, value.y, value.z);
			}

			public static implicit operator GameObjectData.Vector3(UnityEngine.Vector3 value) {
				return new GameObjectData.Vector3(value.x, value.y, value.z);
			}

			public override string ToString() {
				return string.Format("({0:F}, {1:F}, {2:F})", x, y, z);
			}
		}

		[System.Serializable]
		public struct Quaternion
		{
			public float x;
			public float y;
			public float z;
			public float w;

			public Quaternion(float x, float y, float z, float w) {
				this.x = x;
				this.y = y;
				this.z = z;
				this.w = w;
			}

			public static implicit operator UnityEngine.Quaternion(Quaternion value) {
				return new Quaternion(value.x, value.y, value.z, value.w);
			}

			public static implicit operator Quaternion(UnityEngine.Quaternion value) {
				return new UnityEngine.Quaternion(value.x, value.y, value.z, value.w);
			}

			public override string ToString() {
				return string.Format("({0:F}, {1:F}, {2:F}, {3:F})", x, y, z, w);
			}
		}

		public override string ToString() {
			return string.Format("Name: {0}, HP: {1}, Position: {2}, Rotation: {3}, Scale: {4}", name, HP, position, quaternion, scale);
		}
	}
}