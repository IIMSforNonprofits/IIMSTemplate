import { Component } from 'react';
import { Link } from 'react-router-dom';

export class Navbar extends Component {
	render() {
		return (
			<ul>
				<li>
					<Link to="/dashboard">Dashboard</Link>
				</li>
				<li>
					<Link to="/metrics">Metrics</Link>
				</li>
                <li>
                    <Link to="/inventory">Inventory</Link>
                </li>
				<li>
					<Link to="/orders">Orders</Link>
				</li>
				<li>
					<Link to="/logs">Logs</Link>
                </li>
                <li>
                    <Link to="/donors">Donors</Link>
                </li>
                <li>
                    <Link to="/users">Users</Link>
                </li>
			</ul>
		);
	}
}