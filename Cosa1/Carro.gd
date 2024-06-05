extends Spatial

onready var ball = $Bola
onready var car_mesh = $CarMesh
onready var ground_ray = $CarMesh/RayCast

var sphere_offset = Vector3(0, -1.0, 0)
var acceleration = 50
var steering = 21.0
var turn_speed = 5
var turn_stop_limit = 0.75

var speed_input = 0
vare rotate_input = 0


# Called when the node enters the scene tree for the first time.
func _ready():
	ground_ray.add_exception(ball)
	
	fun _physics_proceess(_delta):
		car_mesh.transform.origin = ball.transform.origin + sphere_offset
		
		ball.add_central_force(-car_mesh.global_transform.basis.z * speed_input)
	
	fun _process(delta):
		if not ground_ray.is_colliding():
			return
		speed_input = 0
		speed_input += Input.get_action_strength("accelerate")
		speed_input -= Input.get_action_strength("brake")
		speed_input *= acceleration
		
		rotate_input = 0
		rotate_input += Input.get_action_strength("steer_left")
		rotate_input -= Input.get_action_strength("steer_right")
		rotate_input *= deg2rad(steering)
		
		if ball.linear_velocity.length() > turn_stop_limit:
			var new_basis = car_mesh.global_transform.basis.rotated(car_mesh.global_transform.basis.y, rotate_input)
			car_mesh.global_transform.basis = car_mesh.global_transform.basis.slerp(new_basis, turn_speed * delta)
			car_mesh.global_transform = car_mesh.global_transform.orthonormalized()
		
		
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
