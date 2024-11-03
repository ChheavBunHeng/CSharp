
export default function Product() {
    return (
        <div className="bg-gray-100 py-10">
            <h1 className="text-center font-bold text-3xl mb-6">Our Products</h1>
            <div className="w-[80%] mx-auto flex flex-col">
                {/* Product Showcase */}
                <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
                    {/* Product 1 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Automotive Wiring Harness</h2>
                        <p className="mb-4">
                            Our automotive wiring harnesses are designed for maximum reliability and efficiency, meeting the stringent demands of the automotive industry.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1621575325960-1cb19c58dbb5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDE5fHx3aXJpbmd8ZW58MHx8fHwxNjQ4ODgxMjYx&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Automotive Wiring Harness"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                    {/* Product 2 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Connector Systems</h2>
                        <p className="mb-4">
                            Our connector systems provide excellent connectivity for various automotive applications, ensuring optimal performance and durability.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1562218598-65bb7e7b8f5a?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDF8fG5hdHVyYWwlMjBjb25uZWN0b3J8ZW58MHx8fHwxNjQ4ODgxMzA4&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Connector Systems"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                    {/* Product 3 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Sensor Modules</h2>
                        <p className="mb-4">
                            Our sensor modules are engineered to deliver accurate readings and reliable performance in various automotive environments.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1573686726736-d62da3eecc18?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDE5fHxlY2xhcmF0b3IlMjBzaW5zb3J8ZW58MHx8fHwxNjQ4ODgxMzQ0&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Sensor Modules"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                    {/* Product 4 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Battery Management Systems</h2>
                        <p className="mb-4">
                            Our battery management systems ensure optimal battery life and performance, crucial for modern automotive applications.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1611099893084-cab1e4aeed13?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDF8fGJhdHRlcnklMjBtYW5hZ2VtZW50fGVufDB8fHx8MTY0ODg4MTM2Nw&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Battery Management Systems"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                    {/* Product 5 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Power Distribution Units</h2>
                        <p className="mb-4">
                            Our power distribution units ensure reliable power flow and safety across various automotive systems.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1597391062792-46e097efda96?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDI3fHxwb3dlciUyMGRpc3RyaWJ1dGlvbnxlbnwwfHx8fDE2NDg4ODEzNzM&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Power Distribution Units"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                    {/* Product 6 */}
                    <div className="bg-white shadow-md rounded-lg p-6">
                        <h2 className="text-xl font-semibold mb-4">Lighting Solutions</h2>
                        <p className="mb-4">
                            Our lighting solutions are designed to enhance visibility and safety for all types of vehicles, meeting rigorous standards.
                        </p>
                        <img
                            src="https://images.unsplash.com/photo-1567561285262-6b2392ad9a86?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwzNjUyOXwwfDF8c2VhcmNofDE1fHxsaWdodGluZ3xlbnwwfHx8fDE2NDg4ODE0NTI&ixlib=rb-1.2.1&q=80&w=400"
                            alt="Lighting Solutions"
                            className="w-full h-[200px] object-cover rounded-md mb-4"
                        />
                    </div>
                </div>
            </div>
        </div>
    );
}
