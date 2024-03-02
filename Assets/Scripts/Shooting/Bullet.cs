using UnityEngine;

namespace War.io.Shooting
{
    public class Bullet : MonoBehaviour
    {
        private Vector3 _direction;
        private float _flySpeed;
        private float _maxFlyDistance;
        private float _currentFlyDistance;

        public void Initialise(Vector3 direction, float flySpeed, float maxFlyDistance)
        {
            _direction = direction;
            _flySpeed = flySpeed;
            _maxFlyDistance = maxFlyDistance;
        }

        protected void Update()
        {
            var delta = _flySpeed * Time.deltaTime;
            _currentFlyDistance += delta;
            transform.Translate(_direction * delta);
            
            if (_currentFlyDistance > _maxFlyDistance)
                Destroy(gameObject);
        }
    }
}
