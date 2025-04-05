import React, { useState } from 'react';
import {
  View, Text, FlatList, TouchableOpacity, Image, StyleSheet, ScrollView
} from 'react-native';
import categories from '../../assets/data/categories.json';
import products from '../../assets/data/products.json';

const HomeScreen = ({ navigation }) => {
  const [selectedCategory, setSelectedCategory] = useState(categories[0].id);

  const filteredProducts = products.filter(p => p.categoryId === selectedCategory);

  return (
    <View style={styles.container}>
      {/* Header */}
      <View style={styles.header}>
        <Image source={{ uri: 'https://example.com/logo.png' }} style={styles.logo} />
        <View style={{ flex: 1 }}>
          <Text style={styles.title}>Papa’s Pizza</Text>
          <Text style={styles.subtitle}>Pizza • Pasta • Drinks</Text>
          <View style={styles.row}>
            <Text style={styles.rating}>⭐ 4.8</Text>
            <Text style={styles.status}>🟢 Open</Text>
            <Text style={styles.time}>25 mins</Text>
          </View>
        </View>
      </View>

      {/* Tab categories */}
      <ScrollView horizontal showsHorizontalScrollIndicator={false} style={styles.tabs}>
        {categories.map(cat => (
          <TouchableOpacity
            key={cat.id}
            onPress={() => setSelectedCategory(cat.id)}
            style={[styles.tabItem, selectedCategory === cat.id && styles.tabSelected]}
          >
            <Text
              style={[styles.tabText, selectedCategory === cat.id && styles.tabTextSelected]}
            >
              {cat.name}
            </Text>
          </TouchableOpacity>
        ))}
      </ScrollView>

      {/* Products Grid */}
      <FlatList
        data={filteredProducts}
        keyExtractor={(item) => item.id}
        numColumns={2}
        columnWrapperStyle={{ justifyContent: 'space-between' }}
        contentContainerStyle={{ paddingHorizontal: 12, paddingBottom: 100 }}
        renderItem={({ item }) => (
          <TouchableOpacity
            onPress={() => navigation.navigate('Order', { product: item })}
            style={styles.card}
          >
            <Image source={{ uri: item.image }} style={styles.image} />
            <Text style={styles.name}>{item.name}</Text>
            <Text style={styles.price}>${item.price.toFixed(2)}</Text>
            <View style={styles.addButton}>
              <Text style={{ color: 'white', fontWeight: 'bold' }}>Add</Text>
            </View>
          </TouchableOpacity>
        )}
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: { flex: 1, backgroundColor: '#fff' },
  header: { flexDirection: 'row', padding: 16 },
  logo: { width: 60, height: 60, marginRight: 12, borderRadius: 30 },
  title: { fontSize: 18, fontWeight: 'bold' },
  subtitle: { color: 'gray' },
  row: { flexDirection: 'row', gap: 12, marginTop: 4 },
  rating: { color: '#FFA500' },
  status: { color: 'green' },
  time: { color: 'gray' },
  tabs: { paddingHorizontal: 12, marginVertical: 8 },
  tabItem: {
    marginRight: 16,
    paddingBottom: 4,
    borderBottomWidth: 2,
    borderBottomColor: 'transparent'
  },
  tabSelected: { borderBottomColor: 'green' },
  tabText: { color: 'gray' },
  tabTextSelected: { color: 'green', fontWeight: 'bold' },
  card: {
    width: '48%',
    backgroundColor: '#f9f9f9',
    borderRadius: 12,
    padding: 12,
    marginBottom: 16,
    alignItems: 'center',
  },
  image: { width: 100, height: 100, borderRadius: 50, marginBottom: 8 },
  name: { fontWeight: 'bold', textAlign: 'center', marginBottom: 4 },
  price: { color: 'green', marginBottom: 8 },
  addButton: {
    backgroundColor: 'green',
    paddingHorizontal: 16,
    paddingVertical: 6,
    borderRadius: 20,
  },
});

export default HomeScreen;