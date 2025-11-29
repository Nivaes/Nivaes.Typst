#[unsafe(no_mangle)]
pub extern "C" fn add_numbers(number1: i32, number2: i32) -> i32 {
    println!("Hello from rust!");
    number1 + number2
}

#[unsafe(no_mangle)]
pub extern "C" fn hello_from_rust(a: i32) {
	println!("Hello from Rust: {}", a);
}

#[unsafe(no_mangle)]
pub extern "C" fn say_hello(cb: extern "C" fn(a: i32)) {
	cb(7);
}
