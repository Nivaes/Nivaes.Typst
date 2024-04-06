#[no_mangle]
pub extern fn add_numbers(number1: i32, number2: i32) -> i32 {
    println!("Hello from rust!");
    number1 + number2
}

#[no_mangle]
pub extern fn hello_from_rust(a: i32) {
	println!("Hello from Rust: {}", a);
}

#[no_mangle]
pub extern fn say_hello(cb: extern fn(a: i32)) {
	cb(7);
}